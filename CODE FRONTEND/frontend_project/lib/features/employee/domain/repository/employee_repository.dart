import 'package:frontend_project/core/error/failure.dart';
import 'package:frontend_project/features/employee/domain/entities/employee.dart';
import 'package:dartz/dartz.dart';

abstract class EmployeeRepository {
  Future<Either<Failure, Employee>> getEmployeeById(int id);
  Future<Either<Failure, List<Employee>>> getAllEmployee();
  Future<Either<Failure, bool>> createEmployee(Employee employee);
  Future<Either<Failure, bool>> updateEmployee(Employee employee);
  Future<Either<Failure, bool>> deleteEmployee(int id);
}
