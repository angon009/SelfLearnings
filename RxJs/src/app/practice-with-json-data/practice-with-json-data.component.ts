import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable, from } from 'rxjs';
import {
  concatMap,
  delay,
  filter,
  map,
  mergeMap,
  reduce,
  scan,
  switchMap,
  take,
  tap,
} from 'rxjs/operators';

@Component({
  selector: 'app-practice-with-json-data',
  templateUrl: './practice-with-json-data.component.html',
  styleUrls: ['./practice-with-json-data.component.css'],
})
export class PracticeWithJsonDataComponent implements OnInit {
  constructor(private http: HttpClient) {}

  employees: any[] = [];

  ngOnInit(): void {
    this.fetchData();
  }

  fetchData() {
    this.http.get<any[]>('/assets/employees.json').subscribe((data) => {
      this.employees = data;
      //this.mapOperator();
      //this.filterOperator();
      //this.mergeMapOperator();
      //this.switchMapOperator();
      //this.takeOperator();
      //this.tapOperator();
      //this.concatMapOperator();
      //this.reduceOperator();
      //this.scanOperator();
    });
  }

  mapOperator() {
    const mappedData = from(this.employees).pipe(
      map((employee) => {
        return {
          id: employee.id,
          name: employee.name.toUpperCase(),
          designation: `Senior ${employee.designation}`,
          salary: employee.salary,
          joiningDate: employee.joiningDate,
        };
      })
    );
    this.employees = [];

    mappedData.subscribe((mappedEmployee) => {
      this.employees.push(mappedEmployee);
    });
  }

  mergeMapOperator() {
    const margeMappedData = from(this.employees).pipe(
      mergeMap((employee) => {
        return this.fetchAdditionalDetails(employee.id).pipe(
          map((details) => {
            return {
              id: employee.id,
              name: employee.name,
              designation: employee.designation,
              salary: details.salary,
              joiningDate: details.joiningDate,
            };
          })
        );
      })
    );
    this.employees = [];

    margeMappedData.subscribe((margeMappedEmployee) => {
      this.employees.push(margeMappedEmployee);
    });
  }

  switchMapOperator() {
    const switchedData = from(this.employees).pipe(
      switchMap((employee) => {
        return this.fetchAdditionalDetails(employee.id).pipe(
          map((details) => {
            return {
              id: employee.id,
              name: employee.name,
              designation: employee.designation,
              salary: details.salary,
              joiningDate: details.joiningDate,
            };
          })
        );
      })
    );
    this.employees = [];

    switchedData.subscribe((switchedEmployee) => {
      this.employees.push(switchedEmployee);
    });
  }

  concatMapOperator() {
    const concatenatedData = from(this.employees).pipe(
      concatMap((employee) => {
        return this.fetchAdditionalDetails(employee.id).pipe(
          delay(1000),
          map((details) => {
            return {
              id: employee.id,
              name: employee.name,
              designation: employee.designation,
              salary: details.salary,
              joiningDate: details.joiningDate,
            };
          })
        );
      })
    );

    this.employees = [];

    concatenatedData.subscribe((concatenatedEmployee) => {
      this.employees.push(concatenatedEmployee);
    });
  }

  filterOperator() {
    const filteredData = from(this.employees).pipe(
      filter((employee) => employee.salary >= 70000)
    );
    this.employees = [];

    filteredData.subscribe((filteredEmployee) => {
      this.employees.push(filteredEmployee);
    });
  }

  takeOperator() {
    const takenData = from(this.employees).pipe(take(3));

    this.employees = [];

    takenData.subscribe((takenEmployee) => {
      this.employees.push(takenEmployee);
    });
  }

  tapOperator() {
    from(this.employees)
      .pipe(
        tap((employee) => {
          console.log('Original Employee:', employee);
        })
      )
      .subscribe();
  }

  reduceOperator() {
    from([1, 2, 3])
      .pipe(reduce((acc, value) => acc + value, 0))
      .subscribe((result) => {
        console.log(result); // Output: 6 (1 + 2 + 3)
      });
  }

  scanOperator() {
    from([1, 2, 3, 4, 5])
      .pipe(scan((acc, value) => acc + value, 0))
      .subscribe((result) => {
        console.log(result); // Output: 1, 3, 6, 10, 15
      });
  }

  fetchAdditionalDetails(employeeId: number): Observable<any> {
    return this.http
      .get<any[]>('/assets/employees.json')
      .pipe(
        map((employees) =>
          employees.find((employee) => employee.id === employeeId)
        )
      );
  }
}
