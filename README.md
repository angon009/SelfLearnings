**RxJs Operators**

- **Map :**  It is used to transform the items emitted by an observable into new values. It takes an observable as its input, applies a transformation function to each emitted value, and returns a new observable with the transformed values. Example : 

```
mapOperator() {

    const mappedData = from(this.employees).pipe(

      map((employee) => {                      

        return {

         id: employee.id,

          name: employee.name.toUpperCase(),

          designation: Senior ${employee.designation},

          salary: employee.salary,

          joiningDate: employee.joiningDate

        };

      })

    );

    this.employees = [];

    mappedData.subscribe((mappedEmployee) => {

      this.employees.push(mappedEmployee);

    });

  }
```

Here, 

‘from’ is used to Convert the values of an array into Observables.

‘pipe’ is used to chain RxJs operators. 

‘map’ is transforming each emitted value to a new value. It takes observables and also returns observables.

‘subscribe’ is used for subscribing to the mappedData observable and providing a callback function to handle the emitted values.

By subscribing to the observable, we ensure that the transformation logic defined within the map operator is executed and the transformed values are processed by the callback function.

**Use case of Map :** 

1\. Data Transformation: The primary use case of the map operator is to transform the data emitted by an observable. We can modify, manipulate, or format the values emitted by the source observable to meet our specific requirements.

2\. Property Extraction: With the map operator, we can extract specific properties from the emitted objects. For example, if we have an observable of user objects and we only need the names of the users, we can use map to extract and emit only the names.

```
const mappedData = from(this.employees).pipe(

      map((employee) => {

        return {

          id: employee.id,

          name: employee.name.toUpperCase()

        };

      })

    );
```
3\. Data Projection: The map operator allows us to project the emitted values into a different structure or shape. We can transform the structure of the emitted objects, combine properties, or even create new objects based on the original values.

```
const mappedData = from(this.employees).pipe(

      map((employee) => {

        return {

          name: employee.name.toUpperCase(),

          designation: Senior ${employee.designation}

        };

      })

    );
```

4\. Data Parsing: If the emitted values are in a serialized format like JSON or a string representation, the map operator can be used to parse and convert them into native objects or appropriate data types.

```
 map((employee) => {

        return {

          id: employee.id,

          name: employee.name.toUpperCase(),

          designation: Senior ${employee.designation},

          salary: employee.salary,

          joiningDate: new Date(employee.joiningDate),

          // Parsing Joining Date

        };

      })
```

- **Merge Map :** It is used to transform the items emitted by an observable into inner observables, and then merge those inner observables into a single observable. It allows us to perform operations that involve asynchronous tasks for each emitted item and combine the results into a single stream. Example : 

```
mergeMapOperator() {

    from(this.employees)

.pipe(

        mergeMap((employee) => {

          return this.fetchAdditionalDetails(employee.id).pipe(

            map((details) => {

              return {

                id: employee.id,

                name: employee.name,

                designation: employee.designation,

                additionalDetails: details,

              };

            })

          );

        })

      )

.subscribe((margeMappedEmployee) => {

        this.employees.push(margeMappedEmployee);

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
```

‘mergeMap’ operator is used to transform each employee into an inner observable by calling the fetchAdditionalDetails() method.

‘fetchAdditionalDetails()’ method is responsible for making an asynchronous HTTP request to fetch additional details for a specific employee. It returns an observable that emits the additional details.

‘map’ operator is used within the mergeMap to transform the employee details and the additional details into a new object with the required properties.

The transformed employee object is then emitted by the inner observable.

‘subscribe’ function is used to subscribe to the resulting observable and receive the merged and mapped employee objects.

**Use case of MergeMap :**
**


1\. Making parallel HTTP requests: When we have multiple items and need to make parallel HTTP requests for each item, we can use mergeMap to map each item to an HTTP request observable and merge them into a single observable stream.

2\. Handling nested subscriptions: If we have nested subscriptions or multiple levels of asynchronous operations, we can use mergeMap to flatten the nested observables and handle them in a sequential or parallel manner.

3\. Handling user interactions and API calls: When dealing with user interactions, such as search inputs or autocomplete, we can use mergeMap to map each user input to an API call observable and merge the results into a single stream. This allows us to handle multiple user inputs and responses efficiently.

4\. Chaining dependent operations: If we have dependent operations that need to be performed in sequence, we can use mergeMap to chain the operations by mapping each operation to an observable and merging them together. This ensures the dependent operations are executed in the desired order.

5\. Handling concurrent tasks: When we have multiple tasks that can be executed concurrently, such as processing data in parallel or performing background tasks, we can use mergeMap to map each task to an observable and merge them into a single observable stream.





- **SwitchMap :**  It is used for mapping each value emitted by an observable to another observable, and then flattening the inner observables into a single observable. It cancels the previous inner observable when a new value is emitted, hence the name "switchMap". Example : 

```
switchMapOperator() {

    const switchedData = from(this.employees).pipe(

      switchMap((employee) => {

        return this.fetchAdditionalDetails(employee.id).pipe(

          map((details) => {

            return {

              name: employee.name,

              designation: employee.designation,

              additionalDetails: details,

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
```

**Use case of SwitchMap :** 

1\. Handling asynchronous requests: When dealing with asynchronous operations like HTTP requests, switchMap() allows us to cancel previous requests and switch to the latest request. This is useful when the order of the responses is not important, and we only care about the latest response.

2\. Auto-complete or type-ahead functionality: In user interfaces where we want to implement auto-complete or type-ahead functionality, switchMap() can be used to cancel previous requests for suggestions and switch to the latest input value. This ensures that we will only receive suggestions for the latest input entered by the user.

3\. Debouncing user input: If we have a scenario where we want to delay the execution of a task until the user has finished typing, switchMap() combined with the debounceTime() operator can be used. It cancels the previous inner observable and switches to the latest one after a specified delay, allowing us to handle only the final value after the user has finished typing.

4\. Real-time updates: When working with real-time data streams or event-based systems, switchMap() can be used to handle new events and switch to the latest event stream. This ensures that we can process the most recent event and discard previous events that are no longer relevant.

5\. Canceling ongoing operations: In scenarios where we have ongoing operations or animations, switchMap() can be used to cancel or interrupt the ongoing operation when a new event or input is received. This can help optimize performance and ensure that only the latest operation is executed.


- **ConcatMap :**  It is used for flattening and merging the results of inner observables in a sequential manner. It operates on each value emitted by the source observable and maps it to an inner observable. It then concatenates the results of those inner observables, ensuring the order of emitted values is preserved. Example : 

```
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

  fetchAdditionalDetails(employeeId: number): Observable<any> {

    return this.http

.get<any[]>('/assets/employees.json')

.pipe(

        map((employees) =>

          employees.find((employee) => employee.id === employeeId)

        )

      );

  }
```

‘concatMap’ operator is used to sequentially concatenate inner observables created by the ‘fetchAdditionalDetails()’ method. For each employee in this.employees, the ‘fetchAdditionalDetails()’ method is called to retrieve additional details based on the employee's ID. The ‘concatMap’ operator ensures that the inner observables are subscribed to and processed sequentially.

Inside the ‘concatMap’ operator, the ‘delay’ operator is used to introduce a delay of 1 second (1000 milliseconds) between each inner observable. 

‘map’ operator is used to transform the received details for each employee. It constructs a new object containing properties like id, name, designation, salary, and joiningDate. The details object received from ‘fetchAdditionalDetails()’ is used to populate the salary and joiningDate properties.

**Use Case of ConcatMap :** 

1\. Making sequential HTTP requests: When we need to make a series of HTTP requests one after the other, and the order of the responses matters, concatMap ensures that the requests are executed sequentially, waiting for each response before triggering the next request.

2\. Processing items in a queue: If we have a queue of items that need to be processed in a specific order, concatMap can be used to process each item sequentially, ensuring that the order is preserved.

3\. Handling user actions or events: In user interfaces, we might want to process user actions or events sequentially, one after the other. For example, if we have a button click event that triggers an action, and we want to process the actions in the order they occurred, concatMap can be used to maintain the sequential execution.

4\. Database operations: When dealing with databases or any kind of data storage, we may have operations that depend on the results of previous operations. concatMap can be used to ensure that the operations are executed in the desired order, guaranteeing that each operation waits for the previous one to complete.

5\. Animation or time-based operations: When dealing with animations or time-based operations, we may want to execute tasks or transformations sequentially with a certain delay between each step. concatMap can be used to achieve this sequential and time-controlled execution.

**Differences between Map, MergeMap, SwitchMap and ConcatMap :** 

**map Operator:**

The map operator is used to transform each value emitted by the source observable into a new value. It applies a transformation function to each value and emits the transformed value as the output. The number of output values is always the same as the number of input values.

**switchMap Operator:**

The switchMap operator is used to map each value emitted by the source observable to an inner observable. It cancels the previous inner observable as soon as a new value is emitted by the source observable, and only emits values from the latest inner observable.

**mergeMap Operator:**

The mergeMap operator is used to map each value emitted by the source observable to an inner observable and merge the emissions of the inner observables into a single observable stream. It allows concurrent execution of the inner observables, and the order of emitted values is not guaranteed.

**concatMap Operator:**

The concatMap operator is used to map each value emitted by the source observable to an inner observable and concatenate the emissions of the inner observables in the order they are received. It ensures sequential execution of the inner observables, waiting for each inner observable to complete before subscribing to the next one.

In summary, map is used for simple value transformation, switchMap cancels the previous inner observable and switches to the latest one, mergeMap allows concurrent execution of inner observables, and concatMap ensures sequential execution and preserves the order of emitted values. The choice of which operator to use depends on the specific requirements of our use case.

- **Filter** : It is used to selectively emit values from an observable based on a specified condition. It filters out values that do not satisfy the condition and only emits the values that pass the condition.The filter operator takes a predicate function that evaluates each value emitted by the source observable. If the predicate function returns true for a value, it will be emitted to the subscriber; otherwise, it will be filtered out. Example : 

```
filterOperator() {

    const filteredData = from(this.employees).pipe(

      filter((employee) => employee.salary >= 70000)

    );

    this.employees = [];

    filteredData.subscribe((filteredEmployee) => {

      this.employees.push(filteredEmployee);

    });

  }

```
In this example, we are using the filter operator to filter out employees whose salary is greater than or equal to 70000.

Here's a breakdown of how the filter operator works:

Step 01. The filter operator takes a predicate function as its argument. This function determines the condition that each value emitted by the source observable must satisfy.

Step 02. For each value emitted by the source observable, the predicate function is applied. If the predicate function returns true for a value, that value is emitted downstream to the subscriber. If the predicate function returns false, the value is filtered out and not emitted.

Step 03. The filtered values are then emitted by the resulting observable.

**Use Case of Filter :** 

1\. Data Filtering: The primary use case of the filter operator is to filter out values from an observable that do not satisfy a specific condition.

2\. Event Filtering: When working with event streams, such as user interactions or sensor data, we can use the filter operator to filter out specific events based on their properties. For instance, we might filter mouse events to only process clicks within a certain area or filter sensor readings to only handle values above a certain threshold.

3\. Permission-based Filtering: In scenarios where we have access control or permission-based systems, we can use the filter operator to filter out data that a user is not authorized to see or manipulate. This can help enforce security and access restrictions on our data streams.

4\. Data Validation: The filter operator can also be used for data validation purposes. We can apply validation rules to an observable stream and filter out values that do not meet the required criteria. For example, we can filter out invalid form inputs or validate and filter out erroneous sensor readings.

5\. Real-time Data Processing: When working with real-time data, such as stock prices or sensor data, we can use the filter operator to process and filter the incoming data stream in real-time. This allows us to react and handle specific data events based on our defined conditions.

- **Take :**  It is used to limit the number of emissions received from an observable. It takes an argument specifying the maximum number of emissions we want to take, and once that number is reached, it automatically completes and unsubscribes from the source observable. Example: 

```
takeOperator() {

    const takenData = from(this.employees).pipe(take(3));

    this.employees = [];

    takenData.subscribe((takenEmployee) => {

      this.employees.push(takenEmployee);

    });

  }
```

The take operator is commonly used in scenarios where we want to limit the number of emitted values, such as taking a specific number of items from a stream or implementing pagination in API requests.

- **Tap :** It is used to perform side effects for each emission of an observable without modifying the emitted values. It is often used for debugging, logging, or triggering actions that don't affect the emitted values. Example : 

```
  tapOperator() {

    from(this.employees)

.pipe(

        tap((employee) => {

          console.log('Original Employee:', employee);

        })

      )

.subscribe();

  }
```

‘tap' operator is applied to the observable, and the callback function logs the original employee object to the console.

We can customize the tap operator's callback function to perform any desired side effects, such as logging, modifying external state, or triggering other actions.

‘subscribe’ method is called without passing any arguments since the purpose is to execute the side effects inside the tap operator. If we want to collect the modified employees, we can modify the code accordingly.


- **Reduce:** It is used to accumulate values emitted by an observable into a single accumulated value. It applies a reducer function to each emitted value and maintains an internal state that gets updated with each value. When the source observable completes, the final accumulated value is emitted by the reduce operator as a single value. Example : 

```
  reduceOperator() {

    from([1, 2, 3])

.pipe(reduce((acc, value) => acc + value, 0))

.subscribe((result) => {

        console.log(result); // Output: 6 (1 + 2 + 3)

      });

  }
```

- **Scan:** This operator is similar to the reduce operator, but it emits the accumulated value for each intermediate step of the accumulation process, rather than emitting only the final accumulated value. Example: 

```
  scanOperator() {

    from([1, 2, 3, 4, 5])

.pipe(scan((acc, value) => acc + value, 0))

.subscribe((result) => {

        console.log(result); // Output: 1, 3, 6, 10, 15

      });

  }
```

