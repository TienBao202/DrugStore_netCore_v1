(function (app) {
    app.controller('customerEditController', customerEditController);

    customerEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function customerEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.customer = {
            Date_Created: new Date(),
            Date_Modified: new Date(),

        };

        $scope.UpdateCustomer = UpdateCustomer;

        function loadCustomerDetail() {
            apiService.get('/Customer/GetById/' + $stateParams.id, null,
                function (result) {
                    $scope.customer = result.data;
                    if (result.data.customer_Type == true) {
                        $scope.customer.customer_Type = 'true';
                    }
                    else {
                        $scope.customer.customer_Type = 'false';
                        $scope.customer.gender = null;
                    }
                    if (result.data.gender == true) {
                        $scope.customer.gender = 'true';
                    }
                    else if (result.data.gender == false) {
                        $scope.customer.gender = 'false';
                    }
                }, function (error) {
                    notificationService.displayError('Không tìm thấy thông tin!');
                });
        }

        function UpdateCustomer() {
            apiService.put('/Customer/UpdateCustomer', $scope.customer,
                function (result) {
                    notificationService.displaySuccess(result.data.first_Name + ' ' + result.data.last_Name + ' đã cập nhật thành công.');
                    $state.go('customers');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }

        loadCustomerDetail();
    }
})(angular.module('drugstore.customers'));