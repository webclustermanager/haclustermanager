import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog'
import { MatTableDataSource } from '@angular/material/table'
import { MatSort, MatSnackBar } from '@angular/material/'
import { MatPaginator } from '@angular/material/paginator'
import { ResourceDialogComponent } from '../resource-dialog/resource-dialog.component';
import { ResourceService } from 'src/app/shared/resource.service';
import { Resource } from 'src/app/shared/resource.model';
import { Observable } from 'rxjs';
import { ConfirmationDialogComponent } from 'src/app/shared/confirmation-dialog/confirmation-dialog.component';

@Component({
  selector: 'app-resource',
  templateUrl: './resource.component.html',
  styleUrls: ['./resource.component.css']
})
export class ResourceComponent implements OnInit {
  public res: Resource[];
  datasource: MatTableDataSource<any>;
  displayedColumns = ['Name', 'Status', 'ResType', 'Location', 'Options'];
  node: string;
  resources: Observable<Resource[]>;
  constructor(private dialog: MatDialog, private service: ResourceService,
    public snackBar: MatSnackBar) {
  }

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  ngOnInit() {
    this.resources = this.service.resources;
    this.service.loadAll();

    this.resources.subscribe(data => {
      this.res = data;
      // console.log(data);
      this.datasource = new MatTableDataSource<any>(this.res);
      this.datasource.sort = this.sort;
      this.datasource.paginator = this.paginator;
    });
  }

  ngAfterViewInit() {
    this.datasource.paginator = this.paginator;
    this.datasource.sort = this.sort;
  }

  applyFilter(filterValue: string) {
    filterValue = filterValue.trim();
    filterValue = filterValue.toLowerCase();
    this.datasource.filter = filterValue;
  }

  openAddDialog(): void {
    let dialogRef = this.dialog.open(ResourceDialogComponent, {
      width: '450px',
      disableClose: true,
      autoFocus: true
    });

    dialogRef.afterClosed().subscribe(result => {
    })
  }

  openEditDialog(resource: Resource) {
    const dialogRef = this.dialog.open(ResourceDialogComponent, {
      width: '450px',
      data: resource,
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result == "Confirm") {
        this.snackBar.open("Resource edited succesfully");
      }
    });
  }

  openDeleteDialog(resource: Resource) {

    const dialogRef = this.dialog.open(ConfirmationDialogComponent, {
      width: '350px',
      data: "Do you confirm the deletion resource: " + resource.Name + "?"
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.service.delete(resource);
      }
    });
  }

  openMigrateDialog(resource: Resource) {

    const dialogRef = this.dialog.open(ConfirmationDialogComponent, {
      width: '350px',
      data: "Do you confirm the migrate resource: " + resource.Name + "?"
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.service.migrate(resource.Name, this.node);
      }
    });
  }
}


