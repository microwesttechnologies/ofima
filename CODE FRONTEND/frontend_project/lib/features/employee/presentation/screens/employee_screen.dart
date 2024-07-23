import 'package:dio/dio.dart';
import 'package:flutter/material.dart';
import 'package:frontend_project/core/error/failure.dart';
import 'package:frontend_project/features/employee/data/datasources/data_sources_connection.dart';
import 'package:frontend_project/features/employee/data/repository/employee_repository_impl.dart';
import 'package:frontend_project/features/employee/domain/entities/employee.dart';
import 'package:frontend_project/features/employee/domain/use_cases/get_all_employee.dart';

class EmployeeListScreen extends StatefulWidget {
  const EmployeeListScreen({super.key});

  @override
  EmployeeListScreenState createState() => EmployeeListScreenState();
}

class EmployeeListScreenState extends State<EmployeeListScreen> {
  late final GetAllEmployeeUseCase _getAllEmployeesUseCase;
  List<Employee> _employees = [];
  bool _isLoading = false;
  Failure? _failure;

  @override
  void initState() {
    super.initState();
    final employeeDataSource = EmployeeDataSourceImpl(dio: Dio());
    final employeeRepository =
        EmployeeRepositoryImpl(employeeDataSource: employeeDataSource);

    _getAllEmployeesUseCase =
        GetAllEmployeeUseCase(repository: employeeRepository);
    _fetchEmployees();
  }

  Future<void> _fetchEmployees() async {
    setState(() {
      _isLoading = true;
    });

    final result = await _getAllEmployeesUseCase.call();

    result.fold(
      (failure) {
        setState(() {
          _failure = failure;
          _isLoading = false;
        });
      },
      (employees) {
        setState(() {
          _employees = employees;
          _isLoading = false;
        });
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_isLoading) {
      return Scaffold(
        appBar: AppBar(
          title: const Text('Employees'),
        ),
        body: const Center(child: CircularProgressIndicator()),
      );
    }

    if (_failure != null) {
      return Scaffold(
        appBar: AppBar(
          title: const Text('Empleados'),
        ),
        body: Center(
            child: Text('Failed to load employees: ${_failure.toString()}')),
      );
    }

    return Scaffold(
      appBar: AppBar(
        title: const Text('Empleados'),
      ),
      body: ListView.builder(
        itemCount: _employees.length,
        itemBuilder: (context, index) {
          final employee = _employees[index];
          return Container(
            margin: const EdgeInsets.symmetric(horizontal: 10, vertical: 5),
            decoration: BoxDecoration(
              color: const Color.fromARGB(255, 126, 35, 247),
              borderRadius: BorderRadius.circular(10),
              border: Border.all(
                  color: const Color.fromARGB(255, 0, 0, 0), width: 0),
            ),
            child: ListTile(
              title: Text(
                employee.name,
                style: const TextStyle(color: Colors.white), // Texto blanco
              ),
              subtitle: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    'ID: ${employee.id}',
                    style: const TextStyle(color: Colors.white),
                  ),
                  Text(
                    'Identificacion: ${employee.identificationCard}',
                    style: const TextStyle(color: Colors.white),
                  ),
                  Text(
                    'Fecha de ingreso: ${employee.dateOfAdmission}',
                    style: const TextStyle(color: Colors.white),
                  ),
                  Text(
                    'Cargo: ${employee.cargo}',
                    style: const TextStyle(color: Colors.white),
                  ),
                  Text(
                    'Estado: ${employee.state}',
                    style: const TextStyle(color: Colors.white),
                  ),
                ],
              ),
            ),
          );
        },
      ),
    );
  }
}
