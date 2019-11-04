(function (app) {
    app.controller('accountEditController', accountEditController);

    accountEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function accountEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.account = {
            Date_Created: new Date(),
            Date_Modified: new Date()

        };

        $scope.UpdateAccount = UpdateAccount;

        function loadAccounthDetail() {
            apiService.get('/Account/GetById/' + $stateParams.id, null,
                function (result) {
                    $scope.account = result.data;
                   
                }, function (error) {
                    notificationService.displayError('Không tìm thấy thông tin!');
                });
        }

        function UpdateAccount() {
            apiService.put('/Account/Update', $scope.account,
                function (result) {
                    notificationService.displaySuccess('Tài khoản' + result.data.userName +  + ' đã cập nhật thành công.');
                    $state.go('account');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
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

        loadAccounthDetail();
    }
})(angular.module('drugstore.account'));