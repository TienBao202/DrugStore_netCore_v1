(function (app) {
    app.controller('invoiceDetailController', invoiceDetailController);

    invoiceDetailController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function invoiceDetailController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.invoice = {
            Date_Created: new Date(),
            Date_Modified: new Date(),

        };

        $scope.UpdateMedicine = UpdateMedicine;

        function loadMedicineDetail() {
            apiService.get('/Medicine/GetById/' + $stateParams.id, null,
                function (result) {
                    $scope.medicine = result.data;
                }, function (error) {
                    notificationService.displayError('Không tìm thấy thông tin!');
                });
        }

        function UpdateMedicine() {
            apiService.put('/Medicine/Update', $scope.medicine,
                function (result) {
                    notificationService.displaySuccess(result.data.medicine_Name + ' đã cập nhật thành công.');
                    $state.go('customers');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
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

        loadMedicineDetail();
    }
})(angular.module('drugstore.medicine'));