(function (app) {
    app.controller('employeeEditController', employeeEditController);

    employeeEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function employeeEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.employee = {
            Date_Created: new Date(),
            Date_Modified: new Date(),

        };

        $scope.UpdateEmployee = UpdateEmployee;

        function loadEmployeeDetail() {
            apiService.get('/Employee/GetById/' + $stateParams.id, null,
                function (result) {
                    $scope.employee = result.data;
                    if (result.data.status === 1) {
                        $scope.employee.status = '1';
                    }
                    else if (result.data.status === 0) {
                        $scope.employee.status = '0';
                    }
                    if (result.data.gender === true) {
                        $scope.employee.gender = 'true';
                    }
                    else if (result.data.gender === false) {
                        $scope.employee.gender = 'false';
                    }
                }, function (error) {
                    notificationService.displayError('Không tìm thấy thông tin!');
                });
        }

        function UpdateEmployee() {
            apiService.put('/Employee/UpdateEmployee', $scope.employee,
                function (result) {
                    notificationService.displaySuccess(result.data.first_Name + ' ' + result.data.last_Name + ' đã cập nhật thành công.');
                    $state.go('customers');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }

        loadEmployeeDetail();
    }
})(angular.module('drugstore.employees'));