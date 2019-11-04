(function (app) {
    app.controller('supplier_groupEditController', supplier_groupEditController);

    supplier_groupEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function supplier_groupEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.supplier_group = {
            Date_Created: new Date(),
            Date_Modified: new Date(),

        };

        $scope.Updatesupplier_group = Updatesupplier_group;

        function loadSupplier_groupDetail() {
            apiService.get('/Supplier_Group/GetById/' + $stateParams.id, null,
                function (result) {
                    $scope.supplier_group = result.data;
                   
                }, function (error) {
                    notificationService.displayError('Không tìm thấy thông tin!');
                });
        }

        function Updatesupplier_group() {
            apiService.put('/Supplier_Group/Update', $scope.supplier_group,
                function (result) {
                    notificationService.displaySuccess(result.data.supplier_Group_Name + ' đã cập nhật thành công.');
                    $state.go('customers');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }

        loadSupplier_groupDetail();
    }
})(angular.module('drugstore.supplier_group'));