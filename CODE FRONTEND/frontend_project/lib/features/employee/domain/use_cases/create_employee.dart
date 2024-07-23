import 'package:dartz/dartz.dart';
import 'package:frontend_project/core/error/failure.dart';
import 'package:frontend_project/features/employee/domain/entities/employee.dart';
import 'package:frontend_project/features/employee/domain/repository/employee_repository.dart';

class CreateEmployeeUseCase {
  final EmployeeRepository repository;

  CreateEmployeeUseCase({required this.repository});

  Future<Either<Failure, void>> call(Employee employee) {
    return repository.createEmployee(employee);
  }
}
