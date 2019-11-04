(function (app) {
    app.controller('supplierAddController', supplierAddController);

    supplierAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function supplierAddController(apiService, $scope, notificationService, $state) {
        $scope.supplier = {
            Date_Created: new Date(),
            Date_Modified: new Date()
           
        };

        $scope.AddSupplier = AddSupplier;

        function AddSupplier() {
            apiService.post('/Supplier/Create', $scope.supplier,
                function (result) {
                    notificationService.displaySuccess(result.data.supplier_Name + ' đã được thêm mới.');
                    $state.go('supplier');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
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
    }
})(angular.module('drugstore.customers'));