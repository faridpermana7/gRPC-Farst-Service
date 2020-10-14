# gRPCFarstService
![Hex.pm](https://img.shields.io/hexpm/l/grpc) ![GitHub release (latest by date)](https://img.shields.io/github/v/release/faridpermana7/grpcfarstservice) ![GitHub issues](https://img.shields.io/github/issues/faridpermana7/grpcfarstservice)

### AUTHOR : FARID PERMANA

gRPC service that provide service for client like MVC .NET core, with data structure protobuf

## What's new
What's new in version 1.1.1
  1. Implement data access use Entity Framework core
  2. Use MS. SQL Server as database
  3. Make GrpcFarstCommon, library that manage manager on repository
  4. Create manager for handling data access and deliver to service 
  

## Preview: 
![alt text](https://github.com/faridpermana7/faridpermana7.github.io/blob/master/img/grpc-service.PNG "SC")

## How to make new protobuf: 
 1  Open Proto folder
 2  Make new proto
 
## Example Proto Response :

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

