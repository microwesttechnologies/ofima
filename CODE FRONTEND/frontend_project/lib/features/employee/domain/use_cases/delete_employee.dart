import 'package:dartz/dartz.dart';
import 'package:frontend_project/core/error/failure.dart';
import 'package:frontend_project/features/employee/domain/repository/employee_repository.dart';

class DeleteEmployeeUseCase {
  final EmployeeRepository repository;

  DeleteEmployeeUseCase({required this.repository});

  Future<Either<Failure, void>> call(int id) {
    return repository.deleteEmployee(id);
  }
}
