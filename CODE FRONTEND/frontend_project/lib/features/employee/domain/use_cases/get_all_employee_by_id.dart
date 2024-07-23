import 'package:dartz/dartz.dart';
import 'package:frontend_project/core/error/failure.dart';
import 'package:frontend_project/features/employee/domain/entities/employee.dart';
import 'package:frontend_project/features/employee/domain/repository/employee_repository.dart';

class GetEmployeeByIdUseCase {
  final EmployeeRepository repository;

  GetEmployeeByIdUseCase({required this.repository});

  Future<Either<Failure, Employee>> call(int id) {
    return repository.getEmployeeById(id);
  }
}
