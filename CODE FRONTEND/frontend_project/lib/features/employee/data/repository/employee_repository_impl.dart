import 'package:dartz/dartz.dart';
import 'package:dio/dio.dart';
import 'package:frontend_project/core/error/failure.dart';
import 'package:frontend_project/features/employee/data/models/employee_model.dart';
import 'package:frontend_project/features/employee/domain/entities/employee.dart';
import 'package:frontend_project/features/employee/domain/repository/employee_repository.dart';
import 'package:frontend_project/features/employee/data/datasources/data_sources_connection.dart';

class EmployeeRepositoryImpl implements EmployeeRepository {
  final EmployeeDataSource employeeDataSource;

  EmployeeRepositoryImpl({required this.employeeDataSource});

  @override
  Future<Either<Failure, Employee>> getEmployeeById(int id) async {
    try {
      final employee = await employeeDataSource.getEmployee(id);
      return Right(employee);
    } on DioException {
      return Left(ServerFailure());
    }
  }

  @override
  Future<Either<Failure, List<Employee>>> getAllEmployee() async {
    try {
      final employees = await employeeDataSource.getAllEmployees();
      return Right(employees);
    } on DioException {
      return Left(ServerFailure());
    }
  }

  @override
  Future<Either<Failure, bool>> createEmployee(Employee employee) async {
    try {
      final employeeModel = EmployeeModel.fromEntity(employee);
      await employeeDataSource.createEmployee(employeeModel);
      return const Right(true);
    } on DioException {
      return Left(ServerFailure());
    }
  }

  @override
  Future<Either<Failure, bool>> updateEmployee(Employee employee) async {
    try {
      final employeeModel = EmployeeModel.fromEntity(employee);
      await employeeDataSource.updateEmployee(employeeModel);
      return const Right(true);
    } on DioException {
      return Left(ServerFailure());
    }
  }

  @override
  Future<Either<Failure, bool>> deleteEmployee(int id) async {
    try {
      await employeeDataSource.deleteEmployee(id);
      return const Right(true);
    } on DioException {
      return Left(ServerFailure());
    }
  }
}
