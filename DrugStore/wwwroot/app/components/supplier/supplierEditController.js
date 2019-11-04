(function (app) {
    app.controller('supplierEditController', supplierEditController);

    supplierEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function supplierEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.supplier = {
            Date_Created: new Date(),
            Date_Modified: new Date(),

        };

        $scope.UpdateSupplier = UpdateSupplier;

        function loadSupplierDetail() {
            apiService.get('/Supplier/GetById/' + $stateParams.id, null,
                function (result) {
                    $scope.supplier = result.data;
                    
                }, function (error) {
                    notificationService.displayError('Không tìm thấy thông tin!');
                });
        }

        function UpdateSupplier() {
            apiService.put('/Supplier/Update', $scope.supplier,
                function (result) {
                    notificationService.displaySuccess(result.data.supplier_Name + ' đã cập nhật thành công.');
                    $state.go('supplier');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }
        function loadcategory() {
            apiService.get('/Supplier_Group/GetAll', null, function (result) {
                $scope.listgroup = result.data;
            }, function () {
                console.log('Cannot get list position');
            });
        }

        loadcategory();
        loadSupplierDetail();
    }
})(angular.module('drugstore.supplier'));