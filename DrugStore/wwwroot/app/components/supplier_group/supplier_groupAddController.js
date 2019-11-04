(function (app) {
    app.controller('supplier_groupAddController', supplier_groupAddController);

    supplier_groupAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function supplier_groupAddController(apiService, $scope, notificationService, $state) {
        $scope.supplier_group = {
            Date_Created: new Date(),
            Date_Modified: new Date(),
            Status: true
        };
       

        $scope.AddSupplier_group = AddSupplier_group;

        function AddSupplier_group() {
            apiService.post('/Supplier_Group/Create', $scope.supplier_group,
                function (result) {
                    notificationService.displaySuccess(result.data.supplier_Group_Name + ' đã được thêm mới.');
                    $state.go('supplier');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }
    }
})(angular.module('drugstore.supplier_group'));