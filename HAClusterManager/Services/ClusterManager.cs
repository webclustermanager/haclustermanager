using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HAClusterManager.Models
{
    public class ClusterManager : IClusterManager
    {
        private readonly string _cluster_address;
        private readonly string _login;
        private readonly string _password;

        public ClusterManager()
        {
            _cluster_address = "192.168.29.128";
            _login = "root";
            _password = "ny8yjyfe22";
        }

        public IEnumerable<Resource> GetResources()
        {
            cib clusterStatus = null;
            List<Resource> resources = new List<Resource>();
            using (var client = new SshClient(_cluster_address, _login, _password))
            {
                //client.Connect();
                //if (client.IsConnected)
                {
                    //var response = client.RunCommand("pcs cluster cib");

                    XmlSerializer serializer = new XmlSerializer(typeof(cib));
                    string mock = @"<cib crm_feature_set=""3.0.14"" validate-with=""pacemaker-2.10"" epoch=""14"" num_updates=""79"" admin_epoch=""0"" cib-last-written=""Sat Jul  6 14:25:44 2019"" update-origin=""node1.test.com"" update-client=""cibadmin"" update-user=""root"" have-quorum=""1"" dc-uuid=""1"">
	<configuration>
		<crm_config>
			<cluster_property_set id=""cib-bootstrap-options"">
				<nvpair id=""cib-bootstrap-options-have-watchdog"" name=""have-watchdog"" value=""false""/>
				<nvpair id=""cib-bootstrap-options-dc-version"" name=""dc-version"" value=""1.1.18-11.el7_5.3-2b07d5c5a9""/>
				<nvpair id=""cib-bootstrap-options-cluster-infrastructure"" name=""cluster-infrastructure"" value=""corosync""/>
				<nvpair id=""cib-bootstrap-options-cluster-name"" name=""cluster-name"" value=""TestCluster""/>
				<nvpair id=""cib-bootstrap-options-stonith-enabled"" name=""stonith-enabled"" value=""false""/>
			</cluster_property_set>
		</crm_config>
		<nodes>
			<node id=""1"" uname=""node1.test.com""/>
			<node id=""2"" uname=""node2.test.com""/>
			<node id=""3"" uname=""node3.test.com""/>
		</nodes>
		<resources>
			<group id=""apachegroup"">
				<primitive class=""ocf"" id=""fs_res"" provider=""heartbeat"" type=""Filesystem"">
					<instance_attributes id=""fs_res-instance_attributes"">
						<nvpair id=""fs_res-instance_attributes-device"" name=""device"" value=""/dev/sdb""/>
						<nvpair id=""fs_res-instance_attributes-directory"" name=""directory"" value=""/var/www/html""/>
						<nvpair id=""fs_res-instance_attributes-fstype"" name=""fstype"" value=""xfs""/>
					</instance_attributes>
					<operations>
						<op id=""fs_res-monitor-interval-20"" interval=""20"" name=""monitor"" timeout=""40""/>
						<op id=""fs_res-notify-interval-0s"" interval=""0s"" name=""notify"" timeout=""60""/>
						<op id=""fs_res-start-interval-0s"" interval=""0s"" name=""start"" timeout=""60""/>
						<op id=""fs_res-stop-interval-0s"" interval=""0s"" name=""stop"" timeout=""60""/>
					</operations>
				</primitive>
				<primitive class=""ocf"" id=""httpd_res"" provider=""heartbeat"" type=""apache"">
					<instance_attributes id=""httpd_res-instance_attributes"">
						<nvpair id=""httpd_res-instance_attributes-configfile"" name=""configfile"" value=""/etc/httpd/conf/httpd.conf""/>
						<nvpair id=""httpd_res-instance_attributes-statusurl"" name=""statusurl"" value=""http://127.0.0.1/server-status""/>
					</instance_attributes>
					<operations>
						<op id=""httpd_res-monitor-interval-10"" interval=""10"" name=""monitor"" timeout=""20s""/>
						<op id=""httpd_res-start-interval-0s"" interval=""0s"" name=""start"" timeout=""40s""/>
						<op id=""httpd_res-stop-interval-0s"" interval=""0s"" name=""stop"" timeout=""60s""/>
					</operations>
				</primitive>
				<primitive class=""ocf"" id=""web_ip"" provider=""heartbeat"" type=""IPaddr2"">
					<instance_attributes id=""web_ip-instance_attributes"">
						<nvpair id=""web_ip-instance_attributes-cidr_netmask"" name=""cidr_netmask"" value=""24""/>
						<nvpair id=""web_ip-instance_attributes-ip"" name=""ip"" value=""192.168.1.175""/>
					</instance_attributes>
					<operations>
						<op id=""web_ip-monitor-interval-10s"" interval=""10s"" name=""monitor"" timeout=""20s""/>
						<op id=""web_ip-start-interval-0s"" interval=""0s"" name=""start"" timeout=""20s""/>
						<op id=""web_ip-stop-interval-0s"" interval=""0s"" name=""stop"" timeout=""20s""/>
					</operations>
				</primitive>
			</group>
			<clone id=""ping-clone"">
				<primitive class=""ocf"" id=""ping"" provider=""pacemaker"" type=""ping"">
					<instance_attributes id=""ping-instance_attributes"">
						<nvpair id=""ping-instance_attributes-dampen"" name=""dampen"" value=""5s""/>
						<nvpair id=""ping-instance_attributes-host_list"" name=""host_list"" value=""www.wszib.edu.pl""/>
						<nvpair id=""ping-instance_attributes-multiplier"" name=""multiplier"" value=""1000""/>
					</instance_attributes>
					<operations>
						<op id=""ping-monitor-interval-10"" interval=""10"" name=""monitor"" timeout=""60""/>
						<op id=""ping-start-interval-0s"" interval=""0s"" name=""start"" timeout=""60""/>
						<op id=""ping-stop-interval-0s"" interval=""0s"" name=""stop"" timeout=""20""/>
					</operations>
				</primitive>
			</clone>
			<clone id=""webfarm-clone"">
				<primitive class=""ocf"" id=""webfarm"" provider=""heartbeat"" type=""apache"">
					<operations>
						<op id=""webfarm-monitor-interval-10"" interval=""10"" name=""monitor"" timeout=""20s""/>
						<op id=""webfarm-start-interval-0s"" interval=""0s"" name=""start"" timeout=""40s""/>
						<op id=""webfarm-stop-interval-0s"" interval=""0s"" name=""stop"" timeout=""60s""/>
					</operations>
				</primitive>
			</clone>
		</resources>
		<constraints>
			<rsc_location id=""location-webfarm-clone-node3.test.com-INFINITY"" node=""node3.test.com"" rsc=""webfarm-clone"" score=""INFINITY""/>
		</constraints>
	</configuration>
	<status>
		<node_state id=""1"" uname=""node1.test.com"" in_ccm=""true"" crmd=""online"" crm-debug-origin=""do_update_resource"" join=""member"" expected=""member"">
			<lrm id=""1"">
				<lrm_resources>
					<lrm_resource id=""ping"" type=""ping"" class=""ocf"" provider=""pacemaker"">
						<lrm_rsc_op id=""ping_last_0"" operation_key=""ping_start_0"" operation=""start"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""12:5:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;12:5:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""34"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416591"" last-rc-change=""1562416591"" exec-time=""2285"" queue-time=""0"" op-digest=""5d519bcdd02256be71a3bd7f1feea7a1""/>
						<lrm_rsc_op id=""ping_monitor_10000"" operation_key=""ping_monitor_10000"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""13:5:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;13:5:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""35"" rc-code=""0"" op-status=""0"" interval=""10000"" last-rc-change=""1562416594"" exec-time=""2204"" queue-time=""0"" op-digest=""7002163c0d40d737856b2384ade67846""/>
					</lrm_resource>
					<lrm_resource id=""fs_res"" type=""Filesystem"" class=""ocf"" provider=""heartbeat"">
						<lrm_rsc_op id=""fs_res_last_0"" operation_key=""fs_res_stop_0"" operation=""stop"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""7:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;7:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""33"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416587"" last-rc-change=""1562416587"" exec-time=""529"" queue-time=""0"" op-digest=""dced8c5faae5ba6c0a019cc10e777b8d""/>
						<lrm_rsc_op id=""fs_res_monitor_20000"" operation_key=""fs_res_monitor_20000"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""8:1:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;8:1:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""25"" rc-code=""0"" op-status=""0"" interval=""20000"" last-rc-change=""1562416581"" exec-time=""195"" queue-time=""0"" op-digest=""23659f416e5bc29061f1b99822fb0bfa""/>
					</lrm_resource>
					<lrm_resource id=""webfarm"" type=""apache"" class=""ocf"" provider=""heartbeat"">
						<lrm_rsc_op id=""webfarm_last_0"" operation_key=""webfarm_start_0"" operation=""start"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""25:6:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;25:6:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""36"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416603"" last-rc-change=""1562416603"" exec-time=""383"" queue-time=""0"" op-digest=""f2317cad3d54cec5d7d7aa7d0bf35cf8""/>
						<lrm_rsc_op id=""webfarm_monitor_10000"" operation_key=""webfarm_monitor_10000"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""26:6:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;26:6:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""37"" rc-code=""0"" op-status=""0"" interval=""10000"" last-rc-change=""1562416604"" exec-time=""157"" queue-time=""0"" op-digest=""4811cef7f7f94e3a35a70be7916cb2fd""/>
					</lrm_resource>
					<lrm_resource id=""httpd_res"" type=""apache"" class=""ocf"" provider=""heartbeat"">
						<lrm_rsc_op id=""httpd_res_last_0"" operation_key=""httpd_res_stop_0"" operation=""stop"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""10:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;10:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""31"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416585"" last-rc-change=""1562416585"" exec-time=""2169"" queue-time=""0"" op-digest=""42f59db5567f7f65c7c7e452144ca1cd""/>
						<lrm_rsc_op id=""httpd_res_monitor_10000"" operation_key=""httpd_res_monitor_10000"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""10:1:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;10:1:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""27"" rc-code=""0"" op-status=""0"" interval=""10000"" last-rc-change=""1562416584"" exec-time=""125"" queue-time=""0"" op-digest=""23ab7f8d4f68b1ac398557a53de20a10""/>
					</lrm_resource>
					<lrm_resource id=""web_ip"" type=""IPaddr2"" class=""ocf"" provider=""heartbeat"">
						<lrm_rsc_op id=""web_ip_last_0"" operation_key=""web_ip_stop_0"" operation=""stop"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""3:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;3:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node1.test.com"" call-id=""29"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416584"" last-rc-change=""1562416584"" exec-time=""68"" queue-time=""1"" op-digest=""31d948218b99e4c49be61d4665701ea4""/>
						<lrm_rsc_op id=""web_ip_last_failure_0"" operation_key=""web_ip_start_0"" operation=""start"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""11:1:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:1;11:1:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason=""Unable to find nic or netmask."" on_node=""node1.test.com"" call-id=""28"" rc-code=""1"" op-status=""0"" interval=""0"" last-run=""1562416584"" last-rc-change=""1562416584"" exec-time=""111"" queue-time=""0"" op-digest=""31d948218b99e4c49be61d4665701ea4""/>
					</lrm_resource>
				</lrm_resources>
			</lrm>
			<transient_attributes id=""1"">
				<instance_attributes id=""status-1"">
					<nvpair id=""status-1-fail-count-web_ip.start_0"" name=""fail-count-web_ip#start_0"" value=""INFINITY""/>
					<nvpair id=""status-1-last-failure-web_ip.start_0"" name=""last-failure-web_ip#start_0"" value=""1562416584""/>
					<nvpair id=""status-1-pingd"" name=""pingd"" value=""1000""/>
				</instance_attributes>
			</transient_attributes>
		</node_state>
		<node_state id=""2"" uname=""node2.test.com"" crmd=""online"" crm-debug-origin=""do_update_resource"" in_ccm=""true"" join=""member"" expected=""member"">
			<lrm id=""2"">
				<lrm_resources>
					<lrm_resource id=""fs_res"" type=""Filesystem"" class=""ocf"" provider=""heartbeat"">
						<lrm_rsc_op id=""fs_res_last_0"" operation_key=""fs_res_start_0"" operation=""start"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""8:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;8:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""14"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416587"" last-rc-change=""1562416587"" exec-time=""936"" queue-time=""0"" op-digest=""dced8c5faae5ba6c0a019cc10e777b8d""/>
						<lrm_rsc_op id=""fs_res_monitor_20000"" operation_key=""fs_res_monitor_20000"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""9:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;9:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""15"" rc-code=""0"" op-status=""0"" interval=""20000"" last-rc-change=""1562416588"" exec-time=""153"" queue-time=""0"" op-digest=""23659f416e5bc29061f1b99822fb0bfa""/>
					</lrm_resource>
					<lrm_resource id=""httpd_res"" type=""apache"" class=""ocf"" provider=""heartbeat"">
						<lrm_rsc_op id=""httpd_res_last_0"" operation_key=""httpd_res_start_0"" operation=""start"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""11:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;11:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""16"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416588"" last-rc-change=""1562416588"" exec-time=""1689"" queue-time=""0"" op-digest=""42f59db5567f7f65c7c7e452144ca1cd""/>
						<lrm_rsc_op id=""httpd_res_monitor_10000"" operation_key=""httpd_res_monitor_10000"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""12:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;12:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""17"" rc-code=""0"" op-status=""0"" interval=""10000"" last-rc-change=""1562416590"" exec-time=""198"" queue-time=""0"" op-digest=""23ab7f8d4f68b1ac398557a53de20a10""/>
					</lrm_resource>
					<lrm_resource id=""web_ip"" type=""IPaddr2"" class=""ocf"" provider=""heartbeat"">
						<lrm_rsc_op id=""web_ip_last_0"" operation_key=""web_ip_stop_0"" operation=""stop"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""3:4:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;3:4:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""19"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416591"" last-rc-change=""1562416591"" exec-time=""196"" queue-time=""0"" op-digest=""31d948218b99e4c49be61d4665701ea4""/>
						<lrm_rsc_op id=""web_ip_last_failure_0"" operation_key=""web_ip_start_0"" operation=""start"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""13:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:1;13:3:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason=""Unable to find nic or netmask."" on_node=""node2.test.com"" call-id=""18"" rc-code=""1"" op-status=""0"" interval=""0"" last-run=""1562416590"" last-rc-change=""1562416590"" exec-time=""159"" queue-time=""0"" op-digest=""31d948218b99e4c49be61d4665701ea4""/>
					</lrm_resource>
					<lrm_resource id=""ping"" type=""ping"" class=""ocf"" provider=""pacemaker"">
						<lrm_rsc_op id=""ping_last_0"" operation_key=""ping_start_0"" operation=""start"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""14:5:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;14:5:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""31"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416596"" last-rc-change=""1562416596"" exec-time=""4288"" queue-time=""0"" op-digest=""5d519bcdd02256be71a3bd7f1feea7a1""/>
						<lrm_rsc_op id=""ping_monitor_10000"" operation_key=""ping_monitor_10000"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""18:6:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;18:6:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""32"" rc-code=""0"" op-status=""0"" interval=""10000"" last-rc-change=""1562416600"" exec-time=""3152"" queue-time=""1"" op-digest=""7002163c0d40d737856b2384ade67846""/>
					</lrm_resource>
					<lrm_resource id=""webfarm"" type=""apache"" class=""ocf"" provider=""heartbeat"">
						<lrm_rsc_op id=""webfarm_last_0"" operation_key=""webfarm_monitor_0"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""6:4:7:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;6:4:7:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""29"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416591"" last-rc-change=""1562416591"" exec-time=""237"" queue-time=""2"" op-digest=""f2317cad3d54cec5d7d7aa7d0bf35cf8""/>
						<lrm_rsc_op id=""webfarm_last_failure_0"" operation_key=""webfarm_monitor_0"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""6:4:7:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;6:4:7:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""29"" rc-code=""0"" op-status=""0"" interval=""0"" last-run=""1562416591"" last-rc-change=""1562416591"" exec-time=""237"" queue-time=""2"" op-digest=""f2317cad3d54cec5d7d7aa7d0bf35cf8""/>
						<lrm_rsc_op id=""webfarm_monitor_10000"" operation_key=""webfarm_monitor_10000"" operation=""monitor"" crm-debug-origin=""do_update_resource"" crm_feature_set=""3.0.14"" transition-key=""22:5:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" transition-magic=""0:0;22:5:0:68e3b1b8-7456-4b4a-af71-3115f39e8b1b"" exit-reason="""" on_node=""node2.test.com"" call-id=""30"" rc-code=""0"" op-status=""0"" interval=""10000"" last-rc-change=""1562416591"" exec-time=""116"" queue-time=""1"" op-digest=""4811cef7f7f94e3a35a70be7916cb2fd""/>
					</lrm_resource>
				</lrm_resources>
			</lrm>
			<transient_attributes id=""2"">
				<instance_attributes id=""status-2"">
					<nvpair id=""status-2-fail-count-web_ip.start_0"" name=""fail-count-web_ip#start_0"" value=""INFINITY""/>
					<nvpair id=""status-2-last-failure-web_ip.start_0"" name=""last-failure-web_ip#start_0"" value=""1562416591""/>
					<nvpair id=""status-2-pingd"" name=""pingd"" value=""1000""/>
				</instance_attributes>
			</transient_attributes>
		</node_state>
	</status>
</cib>
";
                    using (TextReader reader = new StringReader(mock/*response.Result*/))
                    {
                        clusterStatus = (cib)serializer.Deserialize(reader);
                    }

                    client.Disconnect();
                }

                if(clusterStatus != null)
                {
                    resources.AddRange(GetResources(clusterStatus.configuration.resources.group.primitive, clusterStatus.status));

                    foreach(var clone in clusterStatus.configuration.resources.clone)
                    {
                        resources.AddRange(GetResources(clone.primitive, clusterStatus.status));
                    }

                    //resources.AddRange(GetResources(clusterStatus.configuration.resources.primitive, clusterStatus.status));

                }
            }

            return resources.ToArray();
        }

        private IEnumerable<Resource> GetResources(cibConfigurationResourcesGroupPrimitive[] primitives, cibNode_state[] nodes)
        {
            List<Resource> resources = new List<Resource>();
            if (primitives == null)
                return resources;

            var res = (from a in primitives
                       select new Resource
                       {
                           Name = a.id,
                           Class = a.@class,
                           Provider = a.provider,
                           Type = a.type,
                           Operations = GetOperations(a.operations),
                           Attributes = GetAttributes(a.instance_attributes),
                           Location = GetResourceStartedNodeName(nodes, a.id),
                           Status = FindStatus(nodes, a.id),
                           ResType = $"{a.@class}:{a.provider}:{a.type}"
                           //Maintenance = a.maintenance,
                           //Standby = a.standby
                       }).ToList();

            resources.AddRange(res);

            return resources;
        }

        private IEnumerable<Resource> GetResources(cibConfigurationResourcesClonePrimitive primitives, cibNode_state[] nodes)
        {
            List<Resource> resources = new List<Resource>();
            if (primitives == null)
                return resources;

            var res = new Resource()
            {
                Name = primitives.id,
                Class = primitives.@class,
                Provider = primitives.provider,
                Type = primitives.type,
                Operations = GetOperations(primitives.operations),
                Attributes = GetAttributes(primitives.instance_attributes),
                Location = GetResourceStartedNodeName(nodes, primitives.id),
                Status = FindStatus(nodes, primitives.id),
                ResType = $"{primitives.@class}:{primitives.provider}:{primitives.type}"
                //Maintenance = a.maintenance,
                //Standby = a.standby
            };

            resources.Add(res);

            return resources;
        }

        //private IEnumerable<Resource> GetResources(cibConfigurationResourcesPrimitive primitives, cibNode_state[] nodes)
        //{
        //    List<Resource> resources = new List<Resource>();
        //    if (primitives == null)
        //        return resources;

        //    var res = new Resource()
        //    {
        //        Name = primitives.id,
        //        Class = primitives.@class,
        //        // Provider = primitives.provider,
        //        Type = primitives.type,
        //        Operations = GetOperations(primitives.operations.op),
        //        Attributes = GetAttributes(primitives.instance_attributes),
        //        Location = GetResourceStartedNodeName(nodes, primitives.id),
        //        Status = FindStatus(nodes, primitives.id),
        //        ResType = $"{primitives.@class}:{primitives.type}"
        //        //Maintenance = a.maintenance,
        //        //Standby = a.standby
        //    };

        //    resources.Add(res);

        //    return resources;
        //}

        private Operation[] GetOperations(cibConfigurationResourcesGroupPrimitiveOP[] op)
        {
            List<Operation> operations = new List<Operation>();
            foreach(var o in op)
            {
                operations.Add(new Operation() { Name = o.name, Interval = o.interval, Timeout = o.timeout });
            }

            return operations.ToArray();
        }

        private Operation[] GetOperations(cibConfigurationResourcesClonePrimitiveOP[] op)
        {
            List<Operation> operations = new List<Operation>();
            foreach (var o in op)
            {
                operations.Add(new Operation() { Name = o.name, Interval = o.interval, Timeout = o.timeout.ToString() });
            }

            return operations.ToArray();
        }

        //private Operation[] GetOperations(cibConfigurationResourcesPrimitiveOperationsOP op)
        //{
        //    List<Operation> operations = new List<Operation>();
        //    //foreach (var o in op)
        //    //{
        //        operations.Add(new Operation() { Name = op.name, Interval = op.interval });
        //    //}

        //    return operations.ToArray();
        //}

        private Attribute[] GetAttributes(cibConfigurationResourcesGroupPrimitiveInstance_attributes attr)
        {
            List<Attribute> attributes = new List<Attribute>();

            if(attr != null)
            {
                foreach (var n in attr.nvpair)
                {
                    attributes.Add(new Attribute() { Name = n.name, Value = n.value });
                }
            }

            return attributes.ToArray();
        }

        private Attribute[] GetAttributes(cibConfigurationResourcesClonePrimitiveInstance_attributes attr)
        {
            List<Attribute> attributes = new List<Attribute>();

            if(attr != null)
            {
                foreach (var n in attr.nvpair)
                {
                    attributes.Add(new Attribute() { Name = n.name, Value = n.value });
                }
            }

            return attributes.ToArray();
        }

        //private Attribute[] GetAttributes(cibConfigurationResourcesPrimitiveInstance_attributes attr)
        //{
        //    List<Attribute> attributes = new List<Attribute>();

        //    //foreach (var n in attr)
        //    //{
        //        attributes.Add(new Attribute() { Name = attr.nvpair.name, Value = attr.nvpair.value });
        //    //}

        //    return attributes.ToArray();
        //}

        //private Attribute[] GetAttributes(cibConfigurationResourcesPrimitiveMeta_attributes attr)
        //{
        //    List<Attribute> attributes = new List<Attribute>();

        //    //foreach (var n in attr)
        //    //{
        //    attributes.Add(new Attribute() { Name = attr.nvpair.name, Value = attr.nvpair.value });
        //    //}

        //    return attributes.ToArray();
        //}

        private bool FindStatus(cibNode_state[] nodes, string id)
        {
            bool result = false;

            foreach (var n in nodes)
            {
                //foreach(var i in n.Items)
                //{
                //    if(i is cibNode_stateLrm)
                //    {
                        //var lrm = (cibNode_stateLrm)i;
                        foreach (var l in n.lrm.lrm_resources)
                        {
                            if (l.id == id)
                            {
                                result = l.lrm_rsc_op.Select(x => x.operation == "start").FirstOrDefault();
                                if (result == true)
                                {
                                    return true;
                                }
                            }
                        }
                //    }
                //}
        
            }

            return result;
        }

        private string GetResourceStartedNodeName(cibNode_state[] nodes, string id)
        {
            string nodeName = string.Empty;

            foreach (var n in nodes)
            {
                //foreach (var i in n.Items)
                //{
                //    if (i is cibNode_stateLrm)
                //    {
                //        var lrm = (cibNode_stateLrm)i;
                        foreach (var l in n.lrm.lrm_resources)
                        {
                            if (l.id == id)
                            {
                                var node = l.lrm_rsc_op.Where(x => x.operation == "start").FirstOrDefault();
                                if (node != null)
                                    return node.on_node;
                            }
                        }
                //    }
                //}
            }

            return nodeName;
        }

        //Managing Running Resources

        public bool ResourceMove(string resourceID, string nodeName)
        {
            string resourceMoveCmd = $"pcs resource move {resourceID} {nodeName}";
            bool result = ExecuteCmd(resourceMoveCmd);

            return result;
        }

        public bool CreateResource(Resource resource)
        {
            string type = $"{resource.Class}:{resource.Provider}:{resource.Type}";

            string attributes = string.Empty;
            foreach(var attr in resource.Attributes)
            {
                attributes += $"{attr.Name}={attr.Value}";
                attributes += " ";
            }

            string command = $"pcs resource create {resource.Name} ";

            if (attributes != string.Empty)
                command += attributes;

            if (ExecuteCmd(command))
                return true;
            else
                return false;
        }

        public bool UpdateResource(Resource resource)
        {
            return false;
        }


        public bool DeleteResource(string resourceID)
        {
            string command = $"pcs resource delete {resourceID}";
            if (ExecuteCmd(command))
                return true;
            else
                return false;
        }

        private bool ExecuteCmd(string command)
        {
            SshCommand result = null;
            using (var client = new SshClient(_cluster_address, _login, _password))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    result = client.RunCommand(command);
                    result.CommandTimeout = TimeSpan.FromSeconds(2);

                    client.Disconnect();
                }
            }
            if (!string.IsNullOrEmpty(result.Error))
                return true;
            else
                return false;         
        }

        public Status GetClusterStatus()
        {
            Status status = new Status();
            crm_mon clusterStatus = null;
            using (var client = new SshClient(_cluster_address, _login, _password))
            {
                //client.Connect();
                //if (client.IsConnected)
                {
                    //var response = client.RunCommand("crm_mon --as-xml");
                    string res = @"<?xml version=""1.0""?>
<crm_mon version=""1.1.18"">
    <summary>
        <stack type=""corosync"" />
        <current_dc present=""true"" version=""1.1.18-11.el7_5.3-2b07d5c5a9"" name=""node2.test.com"" id=""2"" with_quorum=""true"" />
        <last_update time=""Sun Jul  7 20:32:39 2019"" />
        <last_change time=""Sun Jul  7 20:12:19 2019"" user=""root"" client=""cibadmin"" origin=""node1.test.com"" />
        <nodes_configured number=""3"" expected_votes=""unknown"" />
        <resources_configured number=""9"" disabled=""0"" blocked=""0"" />
        <cluster_options stonith-enabled=""false"" symmetric-cluster=""true"" no-quorum-policy=""stop"" maintenance-mode=""false"" />
    </summary>
    <nodes>
        <node name=""node1.test.com"" id=""1"" online=""true"" standby=""false"" standby_onfail=""false"" maintenance=""false"" pending=""false"" unclean=""false"" shutdown=""false"" expected_up=""true"" is_dc=""false"" resources_running=""4"" type=""member"" />
        <node name=""node2.test.com"" id=""2"" online=""true"" standby=""false"" standby_onfail=""false"" maintenance=""false"" pending=""false"" unclean=""false"" shutdown=""false"" expected_up=""true"" is_dc=""true"" resources_running=""2"" type=""member"" />
        <node name=""node3.test.com"" id=""3"" online=""true"" standby=""false"" standby_onfail=""false"" maintenance=""false"" pending=""false"" unclean=""false"" shutdown=""false"" expected_up=""true"" is_dc=""false"" resources_running=""1"" type=""member"" />
    </nodes>
    <resources>
        <group id=""apachegroup"" number_resources=""3"" >
             <resource id=""fs_res"" resource_agent=""ocf::heartbeat:Filesystem"" role=""Started"" active=""true"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""1"" >
                 <node name=""node1.test.com"" id=""1"" cached=""false""/>
             </resource>
             <resource id=""httpd_res"" resource_agent=""ocf::heartbeat:apache"" role=""Started"" active=""true"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""1"" >
                 <node name=""node1.test.com"" id=""1"" cached=""false""/>
             </resource>
             <resource id=""web_ip"" resource_agent=""ocf::heartbeat:IPaddr2"" role=""Stopped"" active=""false"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""0"" />
        </group>
        <clone id=""ping-clone"" multi_state=""false"" unique=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" >
            <resource id=""ping"" resource_agent=""ocf::pacemaker:ping"" role=""Started"" active=""true"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""1"" >
                <node name=""node1.test.com"" id=""1"" cached=""false""/>
            </resource>
            <resource id=""ping"" resource_agent=""ocf::pacemaker:ping"" role=""Started"" active=""true"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""1"" >
                <node name=""node2.test.com"" id=""2"" cached=""false""/>
            </resource>
            <resource id=""ping"" resource_agent=""ocf::pacemaker:ping"" role=""Started"" active=""true"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""1"" >
                <node name=""node3.test.com"" id=""3"" cached=""false""/>
            </resource>
        </clone>
        <clone id=""webfarm-clone"" multi_state=""false"" unique=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" >
            <resource id=""webfarm"" resource_agent=""ocf::heartbeat:apache"" role=""Started"" active=""true"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""1"" >
                <node name=""node1.test.com"" id=""1"" cached=""false""/>
            </resource>
            <resource id=""webfarm"" resource_agent=""ocf::heartbeat:apache"" role=""Started"" active=""true"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""1"" >
                <node name=""node2.test.com"" id=""2"" cached=""false""/>
            </resource>
            <resource id=""webfarm"" resource_agent=""ocf::heartbeat:apache"" role=""Stopped"" active=""false"" orphaned=""false"" blocked=""false"" managed=""true"" failed=""false"" failure_ignored=""false"" nodes_running_on=""0"" />
        </clone>
    </resources>
    <node_attributes>
        <node name=""node1.test.com"">
            <attribute name=""pingd"" value=""1000"" expected=""1000"" />
        </node>
        <node name=""node2.test.com"">
            <attribute name=""pingd"" value=""1000"" expected=""1000"" />
        </node>
        <node name=""node3.test.com"">
            <attribute name=""pingd"" value=""1000"" expected=""1000"" />
        </node>
    </node_attributes>
    <node_history>
        <node name=""node1.test.com"">
            <resource_history id=""ping"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""46"" task=""start"" last-rc-change=""Sun Jul  7 20:26:37 2019"" last-run=""Sun Jul  7 20:26:37 2019"" exec-time=""2189ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
                <operation_history call=""47"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:26:39 2019"" exec-time=""2187ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""fs_res"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""66"" task=""start"" last-rc-change=""Sun Jul  7 20:30:31 2019"" last-run=""Sun Jul  7 20:30:31 2019"" exec-time=""6721ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
                <operation_history call=""67"" task=""monitor"" interval=""20000ms"" last-rc-change=""Sun Jul  7 20:30:37 2019"" exec-time=""293ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""webfarm"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""49"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:26:52 2019"" exec-time=""0ms"" queue-time=""0ms"" rc=""7"" rc_text=""not running"" />
                <operation_history call=""70"" task=""start"" last-rc-change=""Sun Jul  7 20:31:32 2019"" last-run=""Sun Jul  7 20:31:32 2019"" exec-time=""203ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
                <operation_history call=""71"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:31:32 2019"" exec-time=""201ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""httpd_res"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""68"" task=""start"" last-rc-change=""Sun Jul  7 20:30:38 2019"" last-run=""Sun Jul  7 20:30:38 2019"" exec-time=""6591ms"" queue-time=""1ms"" rc=""0"" rc_text=""ok"" />
                <operation_history call=""69"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:30:44 2019"" exec-time=""140ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""web_ip"" orphan=""false"" migration-threshold=""1000000"" fail-count=""1000000"" last-failure=""Sun Jul  7 20:29:31 2019"">
                <operation_history call=""60"" task=""start"" last-rc-change=""Sun Jul  7 20:29:31 2019"" last-run=""Sun Jul  7 20:29:31 2019"" exec-time=""99ms"" queue-time=""1ms"" rc=""1"" rc_text=""unknown error"" />
                <operation_history call=""61"" task=""stop"" last-rc-change=""Sun Jul  7 20:29:32 2019"" last-run=""Sun Jul  7 20:29:32 2019"" exec-time=""87ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
        </node>
        <node name=""node2.test.com"">
            <resource_history id=""ping"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""32"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:27:24 2019"" exec-time=""0ms"" queue-time=""0ms"" rc=""1"" rc_text=""unknown error"" />
                <operation_history call=""55"" task=""start"" last-rc-change=""Sun Jul  7 20:30:44 2019"" last-run=""Sun Jul  7 20:30:44 2019"" exec-time=""2249ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
                <operation_history call=""56"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:30:47 2019"" exec-time=""2190ms"" queue-time=""1ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""fs_res"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""15"" task=""monitor"" interval=""20000ms"" last-rc-change=""Sun Jul  7 20:27:24 2019"" exec-time=""0ms"" queue-time=""0ms"" rc=""1"" rc_text=""unknown error"" />
                <operation_history call=""52"" task=""stop"" last-rc-change=""Sun Jul  7 20:29:21 2019"" last-run=""Sun Jul  7 20:29:21 2019"" exec-time=""6022ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""webfarm"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""30"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:27:45 2019"" exec-time=""0ms"" queue-time=""0ms"" rc=""7"" rc_text=""not running"" />
                <operation_history call=""57"" task=""start"" last-rc-change=""Sun Jul  7 20:31:32 2019"" last-run=""Sun Jul  7 20:31:32 2019"" exec-time=""475ms"" queue-time=""1ms"" rc=""0"" rc_text=""ok"" />
                <operation_history call=""58"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:31:32 2019"" exec-time=""119ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""httpd_res"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""40"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:28:16 2019"" exec-time=""0ms"" queue-time=""0ms"" rc=""7"" rc_text=""not running"" />
                <operation_history call=""50"" task=""stop"" last-rc-change=""Sun Jul  7 20:29:14 2019"" last-run=""Sun Jul  7 20:29:14 2019"" exec-time=""3701ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""web_ip"" orphan=""false"" migration-threshold=""1000000"" fail-count=""1000000"" last-failure=""Sun Jul  7 20:29:12 2019"">
                <operation_history call=""47"" task=""start"" last-rc-change=""Sun Jul  7 20:28:56 2019"" last-run=""Sun Jul  7 20:28:56 2019"" exec-time=""13295ms"" queue-time=""0ms"" rc=""1"" rc_text=""unknown error"" />
                <operation_history call=""48"" task=""stop"" last-rc-change=""Sun Jul  7 20:29:12 2019"" last-run=""Sun Jul  7 20:29:12 2019"" exec-time=""104ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
        </node>
        <node name=""node3.test.com"">
            <resource_history id=""ping"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""30"" task=""start"" last-rc-change=""Sun Jul  7 20:28:07 2019"" last-run=""Sun Jul  7 20:28:07 2019"" exec-time=""2533ms"" queue-time=""1ms"" rc=""0"" rc_text=""ok"" />
                <operation_history call=""31"" task=""monitor"" interval=""10000ms"" last-rc-change=""Sun Jul  7 20:28:09 2019"" exec-time=""2914ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""fs_res"" orphan=""false"" migration-threshold=""1000000"">
                <operation_history call=""34"" task=""monitor"" interval=""20000ms"" last-rc-change=""Sun Jul  7 20:29:42 2019"" exec-time=""6924ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
                <operation_history call=""38"" task=""stop"" last-rc-change=""Sun Jul  7 20:30:30 2019"" last-run=""Sun Jul  7 20:30:30 2019"" exec-time=""439ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""webfarm"" orphan=""false"" migration-threshold=""1000000"" fail-count=""1000000"" last-failure=""Sun Jul  7 20:31:31 2019"">
                <operation_history call=""40"" task=""start"" last-rc-change=""Sun Jul  7 20:30:49 2019"" last-run=""Sun Jul  7 20:30:49 2019"" exec-time=""41355ms"" queue-time=""1ms"" rc=""1"" rc_text=""unknown error"" />
                <operation_history call=""41"" task=""stop"" last-rc-change=""Sun Jul  7 20:31:31 2019"" last-run=""Sun Jul  7 20:31:31 2019"" exec-time=""422ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
            <resource_history id=""httpd_res"" orphan=""false"" migration-threshold=""1000000"" fail-count=""1000000"" last-failure=""Sun Jul  7 20:30:29 2019"">
                <operation_history call=""35"" task=""start"" last-rc-change=""Sun Jul  7 20:29:49 2019"" last-run=""Sun Jul  7 20:29:49 2019"" exec-time=""40005ms"" queue-time=""0ms"" rc=""1"" rc_text=""unknown error"" />
                <operation_history call=""36"" task=""stop"" last-rc-change=""Sun Jul  7 20:30:29 2019"" last-run=""Sun Jul  7 20:30:29 2019"" exec-time=""272ms"" queue-time=""0ms"" rc=""0"" rc_text=""ok"" />
            </resource_history>
        </node>
    </node_history>
    <failures>
        <failure op_key=""webfarm_monitor_10000"" node=""node1.test.com"" exitstatus=""not running"" exitreason="""" exitcode=""7"" call=""49"" status=""complete"" last-rc-change=""Sun Jul  7 20:26:52 2019"" queued=""0"" exec=""0"" interval=""10000"" task=""monitor"" />
        <failure op_key=""web_ip_start_0"" node=""node1.test.com"" exitstatus=""unknown error"" exitreason=""Unable to find nic or netmask."" exitcode=""1"" call=""60"" status=""complete"" last-rc-change=""Sun Jul  7 20:29:31 2019"" queued=""1"" exec=""99"" interval=""0"" task=""start"" />
        <failure op_key=""ping_monitor_10000"" node=""node2.test.com"" exitstatus=""unknown error"" exitreason="""" exitcode=""1"" call=""32"" status=""Timed Out"" last-rc-change=""Sun Jul  7 20:27:24 2019"" queued=""0"" exec=""0"" interval=""10000"" task=""monitor"" />
        <failure op_key=""fs_res_monitor_20000"" node=""node2.test.com"" exitstatus=""unknown error"" exitreason="""" exitcode=""1"" call=""15"" status=""Timed Out"" last-rc-change=""Sun Jul  7 20:27:24 2019"" queued=""0"" exec=""0"" interval=""20000"" task=""monitor"" />
        <failure op_key=""webfarm_monitor_10000"" node=""node2.test.com"" exitstatus=""not running"" exitreason="""" exitcode=""7"" call=""30"" status=""complete"" last-rc-change=""Sun Jul  7 20:27:45 2019"" queued=""0"" exec=""0"" interval=""10000"" task=""monitor"" />
        <failure op_key=""httpd_res_monitor_10000"" node=""node2.test.com"" exitstatus=""not running"" exitreason="""" exitcode=""7"" call=""40"" status=""complete"" last-rc-change=""Sun Jul  7 20:28:16 2019"" queued=""0"" exec=""0"" interval=""10000"" task=""monitor"" />
        <failure op_key=""web_ip_start_0"" node=""node2.test.com"" exitstatus=""unknown error"" exitreason=""Unable to find nic or netmask."" exitcode=""1"" call=""47"" status=""complete"" last-rc-change=""Sun Jul  7 20:28:56 2019"" queued=""0"" exec=""13295"" interval=""0"" task=""start"" />
        <failure op_key=""webfarm_start_0"" node=""node3.test.com"" exitstatus=""unknown error"" exitreason="""" exitcode=""1"" call=""40"" status=""Timed Out"" last-rc-change=""Sun Jul  7 20:30:49 2019"" queued=""1"" exec=""41355"" interval=""0"" task=""start"" />
        <failure op_key=""httpd_res_start_0"" node=""node3.test.com"" exitstatus=""unknown error"" exitreason="""" exitcode=""1"" call=""35"" status=""Timed Out"" last-rc-change=""Sun Jul  7 20:29:49 2019"" queued=""0"" exec=""40005"" interval=""0"" task=""start"" />
    </failures>
    <tickets>
    </tickets>
    <bans>
    </bans>
</crm_mon>
";
                    XmlSerializer serializer = new XmlSerializer(typeof(crm_mon));

                    using (TextReader reader = new StringReader(res/*response.Result*/))
                    {
                        clusterStatus = (crm_mon)serializer.Deserialize(reader);
                    }

                    client.Disconnect();
                }
            }

            if(clusterStatus != null)
            {
                status.LastUpdate = clusterStatus.summary.last_update.time;
                status.LastChange = clusterStatus.summary.last_change.time;
                status.NodesCount = clusterStatus.summary.nodes_configured.number;
                status.ResourcesCount = clusterStatus.summary.resources_configured.number;

                List<Node> nodes = (from a in clusterStatus.nodes
                             select new Node
                             {
                                 Name = a.name,
                                 Online = a.online,
                                 Maintenance = a.maintenance,
                                 Standby = a.standby
                             }).ToList();

                status.Nodes = nodes.ToArray();
            }

            //return clusterStatus;
            return status;
        }      
    }
}
