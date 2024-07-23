import 'package:frontend_project/features/employee/domain/entities/employee.dart';

class EmployeeModel extends Employee {
  EmployeeModel({
    required super.id,
    required super.identificationCard,
    required super.name,
    required super.picture,
    required super.dateOfAdmission,
    required super.cargo,
    required super.state,
  });

  factory EmployeeModel.fromJson(Map<String, dynamic> json) {
    return EmployeeModel(
      id: json['id'],
      identificationCard: json['identificationCard'],
      name: json['name'],
      picture: json['picture'],
      dateOfAdmission: json['dateOfAdmission'],
      cargo: json['cargo'],
      state: json['state'],
    );
  }

  Map<String, dynamic> toJson() {
    return {
      'id': id,
      'identificationCard': identificationCard,
      'name': name,
      'picture': picture,
      'dateOfAdmission': dateOfAdmission,
      'cargo': cargo,
      'state': state,
    };
  }

  factory EmployeeModel.fromEntity(Employee employee) {
    return EmployeeModel(
      id: employee.id,
      identificationCard: employee.identificationCard,
      name: employee.name,
      picture: employee.picture,
      dateOfAdmission: employee.dateOfAdmission,
      cargo: employee.cargo,
      state: employee.state,
    );
  }
}
