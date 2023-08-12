import { Component } from '@angular/core';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent {
  public name: string = "";
  public employeeId: string = "";

  public addEmployee() {
    alert(`Employee added: ${this.name} ${this.employeeId}`);
  }
}
