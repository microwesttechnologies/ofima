import 'package:dartz/dartz.dart';
import 'package:frontend_project/core/error/failure.dart';
import 'package:frontend_project/features/employee/domain/entities/employee.dart';
import 'package:frontend_project/features/employee/domain/repository/employee_repository.dart';

class GetAllEmployeeUseCase {
  final EmployeeRepository repository;

  GetAllEmployeeUseCase({required this.repository});

  Future<Either<Failure, List<Employee>>> call() {
    return repository.getAllEmployee();
  }
}
