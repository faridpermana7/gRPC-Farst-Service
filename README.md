# gRPCFarstService
![Hex.pm](https://img.shields.io/hexpm/l/grpc) ![GitHub release (latest by date)](https://img.shields.io/github/v/release/faridpermana7/grpcfarstservice) ![GitHub issues](https://img.shields.io/github/issues/faridpermana7/grpcfarstservice)

### AUTHOR : FARID PERMANA

gRPC service that provide service for client like MVC .NET core, with data structure protobuf

## Preview: 
![alt text](https://github.com/faridpermana7/faridpermana7.github.io/blob/master/img/grpc-service.PNG "SC")

## What's new
What's new in version 0.1.1
  1. provide proto service 
  
## Configuration: 
 -  open Proto folder, and make new prot 
 
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

