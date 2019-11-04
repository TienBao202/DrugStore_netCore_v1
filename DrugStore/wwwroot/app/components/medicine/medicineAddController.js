(function (app) {
    app.controller('medicineAddController', medicineAddController);

    medicineAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function medicineAddController(apiService, $scope, notificationService, $state) {
        $scope.medicine = {
            Date_Created: new Date(),
            Date_Modified: new Date(),
            Status: 'true'
        };

        $scope.AddMedicine = AddMedicine;

        function AddMedicine() {
            apiService.post('/Medicine/Create', $scope.medicine,
                function (result) {
                    notificationService.displaySuccess(result.data.medicine_Name + ' đã được thêm mới.');
                    $state.go('medicine');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }

        function loadCategory() {
            apiService.get('/Medicine_Category/GetAll', null, function (result) {
                $scope.listcategory = result.data;
            }, function () {
                console.log('Cannot get list position');
            });
        }

        function loadUnit() {
            apiService.get('/Medicine_Unit/GetAll', null, function (result) {
                $scope.listMedicine_unit = result.data;
            }, function () {
                console.log('Cannot get list position');
            });
        }

        loadCategory();
        loadUnit();
    }
})(angular.module('drugstore.medicine'));