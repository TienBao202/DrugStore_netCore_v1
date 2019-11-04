(function (app) {
    app.controller('medicine_unitAddController', medicine_unitAddController);

    medicine_unitAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function medicine_unitAddController(apiService, $scope, notificationService, $state) {
        $scope.medicine_unit = {
            Date_Created: new Date(),
            Date_Modified: new Date(),
            Status: true

        };

        $scope.AddMedicine_unit = AddMedicine_unit;

        function AddMedicine_unit() {
            apiService.post('/Medicine_Unit/Create', $scope.medicine_unit,
                function (result) {
                    notificationService.displaySuccess(result.data.medicine_Unit_Name + ' đã được thêm mới.');
                    $state.go('medicine');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }
    }
})(angular.module('drugstore.medicine_category'));