import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef } from '@angular/material';
import { Resource } from 'src/app/shared/resource.model';
import { MAT_DIALOG_DATA } from '@angular/material';
import { ResourceService } from 'src/app/shared/resource.service';

@Component({
    selector: 'app-resource-dialog',
    templateUrl: './resource-dialog.component.html',
    styleUrls: ['./resource-dialog.component.css']
})
export class ResourceDialogComponent implements OnInit {

    resource: Resource;

    selectedValue: string;
    selectedCar: string;

    classes: Class[] = [
        { value: 'lsb', viewValue: 'lsb' },
        { value: 'ocf', viewValue: 'ocf' },
        { value: 'service', viewValue: 'service' },
        { value: 'systemd', viewValue: 'systemd' },
        { value: 'stonith', viewValue: 'stonith' },
        { value: 'upstart', viewValue: 'upstart' },
    ];

    types: Type[] = [
        { value: 'IPaddr', viewValue: 'IPaddr' },
        { value: 'IPaddr2', viewValue: 'IPaddr2' },
        { value: 'ipsec', viewValue: 'ipsec' },
        { value: 'Filesystem', viewValue: 'Filesystem' },
        { value: 'pingd', viewValue: 'pingd' },
        { value: 'symlink', viewValue: 'symlink' }
    ];

    providers: Provider[] = [
        { value: 'heartbeat', viewValue: 'heartbeat' },
        { value: 'ocfs2', viewValue: 'ocfs2' },
        { value: 'pacemaker', viewValue: 'pacemake' },
    ];

    constructor(private resourceService: ResourceService,
        private dialogRef: MatDialogRef<ResourceDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public data: Resource) {
    }

    ngOnInit() {
        this.resource = new Resource();

        this.resource.Operations = [];
        this.resource.Attributes = [];

        if (this.data != null) {
            this.resource.Name = this.data.Name;
            this.resource.Class = this.data.Class;
            this.resource.Type = this.data.Type;
            this.resource.Provider = this.data.Provider;
            this.resource.Parameters = this.data.Parameters;
        }
    }

    save() {
        if (this.data == null) {
            this.resourceService.add(this.resource);
        }
        else {
            this.resourceService.update(this.resource);
        }

        this.dialogRef.close(this.resource);
    }

    dismiss() {
        this.dialogRef.close(null);
    }
}

export interface Class {
    value: string;
    viewValue: string;
}

export interface Type {
    value: string;
    viewValue: string;
}

export interface Provider {
    value: string;
    viewValue: string;
}
