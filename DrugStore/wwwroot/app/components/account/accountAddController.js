(function (app) {
    app.controller('accountAddController', accountAddController);

    accountAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function accountAddController(apiService, $scope, notificationService, $state) {
        $scope.account = {
            Date_Created: new Date(),
            Date_Modified: new Date(),
            Status: true
        };
  
        $scope.AddAccount = AddAccount;

        function AddAccount() {
            apiService.post('/Account/Create', $scope.account,
                function (result) {
                    notificationService.displaySuccess('Tài khoản' + result.data.userName + ' đã được thêm mới.');
                    $state.go('account');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }

      

        function loademployee() {
            apiService.get('/Employee/GetAll', null, function (result) {
                $scope.listemployee = result.data;
            }, function () {
                console.log('Cannot get list employee');
            });
        }

        loademployee();
       
    }
})(angular.module('drugstore.account'));