import 'package:frontend_project/features/employee/data/models/employee_model.dart';
import 'package:dio/dio.dart';

abstract class EmployeeDataSource {
  Future<EmployeeModel> getEmployee(int id);
  Future<EmployeeModel> createEmployee(EmployeeModel employee);
  Future<EmployeeModel> updateEmployee(EmployeeModel employee);
  Future<void> deleteEmployee(int id);
  Future<List<EmployeeModel>> getAllEmployees();
}

class EmployeeDataSourceImpl implements EmployeeDataSource {
  final Dio dio;
  final String url = "http://localhost:5293";

  EmployeeDataSourceImpl({required this.dio});

  @override
  Future<EmployeeModel> getEmployee(int id) async {
    try {
      final body = {"employeeId": id};
      final resp = await dio.post(
        '$url/api/Employee/Get-All-Byid',
        data: body,
      );
      return EmployeeModel.fromJson(resp.data);
    } catch (e) {
      throw Exception('Failed to load employee: $e');
    }
  }

  @override
  Future<EmployeeModel> createEmployee(EmployeeModel employee) async {
    try {
      final body = employee.toJson();
      final resp = await dio.post(
        '$url/api/Employee/Create',
        data: body,
      );
      return EmployeeModel.fromJson(resp.data);
    } catch (e) {
      throw Exception('Failed to create employee: $e');
    }
  }

  @override
  Future<EmployeeModel> updateEmployee(EmployeeModel employee) async {
    try {
      final body = employee.toJson();
      final resp = await dio.put(
        '$url/api/Employee/Update',
        data: body,
      );
      return EmployeeModel.fromJson(resp.data);
    } catch (e) {
      throw Exception('Failed to update employee: $e');
    }
  }

  @override
  Future<void> deleteEmployee(int id) async {
    try {
      final body = {"employeeId": id};
      await dio.put(
        '$url/api/Employee/Delete',
        data: body,
      );
    } catch (e) {
      throw Exception('Failed to delete employee: $e');
    }
  }

  @override
  Future<List<EmployeeModel>> getAllEmployees() async {
    try {
      // Ajusta la URL según el entorno que estés usando
      final resp = await dio.get(
        'http://10.0.2.2:5293/api/Employee/Get-All', // Cambia esta URL según sea necesario
      );
      final List<dynamic> data = resp.data;
      return data.map((e) => EmployeeModel.fromJson(e)).toList();
    } catch (e) {
      throw Exception('Failed to load employees: $e');
    }
  }
}
