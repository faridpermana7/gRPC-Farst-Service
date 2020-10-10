# gRPCFarstService

### AUTHOR : FARID PERMANA

gRPC service that provide service for client like MVC .NET core, with data structure protobuf

## Configuration: 
 -  make proto file 


## Example Response : 
  message EmployeeResponse {
      enum Status { 
          NOTFOUND = 0;
          SUCCESS = 1;
          FAILED = 2;
          INTERNALSERVERERROR = 3;
      }
      Status StatusCode = 1;
      string message = 2;
      repeated EmployeeDTO Data = 3; 
  }
 

**EXPLAIN**
> **message** : Represents class on protobuf structure.   

