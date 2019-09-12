import { Component, OnInit } from '@angular/core';
import { NodeService } from 'src/app/shared/node.service';


@Component({
  selector: 'app-node',
  templateUrl: './node.component.html',
  styleUrls: []
})

export class NodeComponent implements OnInit {
  nodeList;

  constructor(private service: NodeService) { }

  ngOnInit() {
    //  this.service.getNodesList().then(res => this.nodeList = res);
  }

}
