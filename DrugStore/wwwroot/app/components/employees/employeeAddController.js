(function (app) {
    app.controller('employeeAddController', employeeAddController);

    employeeAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function employeeAddController(apiService, $scope, notificationService, $state) {
        $scope.employee = {
            Date_Created: new Date(),
            Date_Modified: new Date(),
            Status: true,
            Gender: 'true',
            ID_Agency: 1
        };

        $scope.AddEmployee = AddEmployee;

        function AddEmployee() {
            apiService.post('/Employee/CreateEmployee', $scope.employee,
                function (result) {
                    notificationService.displaySuccess(result.data.first_Name + ' ' + result.data.last_Name + ' đã được thêm mới.');
                    $state.go('employees');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }
        function loadPosition() {
            apiService.get('/Position/GetAll', null, function (result) {
                $scope.listposition = result.data;
            }, function () {
                console.log('Cannot get list position');
            });
        }
        function loadAgency() {
            apiService.get('/Agency/GetAll', null, function (result) {
                $scope.listagency = result.data;
            }, function () {
                console.log('Cannot get list agency');
            });
        }
        loadPosition();
        loadAgency();
    }
})(angular.module('drugstore.employees'));