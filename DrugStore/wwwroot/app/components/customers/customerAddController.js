(function (app) {
    app.controller('customerAddController', customerAddController);

    customerAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function customerAddController(apiService, $scope, notificationService, $state) {
        $scope.customer = {
            Date_Created: new Date(),
            Date_Modified: new Date(),
            Status: true,
            Customer_Type: 'true',
            Gender: 'true'
        };
        $scope.changeGender = changeGender;
        function changeGender() {
            if ($scope.customer.Customer_Type == true) {
                $scope.customer.Customer_Type = 'true';
            }
            else if ($scope.Customer.customer_Type == false) {
                $scope.customer.Customer_Type = 'false';
                $scope.customer.Gender = null;
            }
        }

        $scope.AddCustomer = AddCustomer;

        function AddCustomer() {
            apiService.post('/Customer/CreateCustomer', $scope.customer,
                function (result) {
                    notificationService.displaySuccess(result.data.first_Name + ' ' + result.data.last_Name + ' đã được thêm mới.');
                    $state.go('customers');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }
    }
})(angular.module('drugstore.customers'));