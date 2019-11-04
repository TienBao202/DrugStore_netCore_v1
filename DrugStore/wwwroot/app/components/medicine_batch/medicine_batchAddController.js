(function (app) {
    app.controller('medicine_batchAddController', medicine_batchAddController);

    medicine_batchAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function medicine_batchAddController(apiService, $scope, notificationService, $state) {
        $scope.medicine_batch = {
            Date_Created: new Date(),
            Date_Modified: new Date(),
            Status: true
        };
  
        $scope.AddMedicine_batch = AddMedicine_batch;

        function AddMedicine_batch() {
            apiService.post('/Medicine_Batch/Create', $scope.medicine_batch,
                function (result) {
                    notificationService.displaySuccess('Lô thuốc' + result.data.medicine_Batch_Code + ' đã được thêm mới.');
                    $state.go('customers');
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

        function loadCountry() {
            apiService.get('/Country/GetAll', null, function (result) {
                $scope.listcountry = result.data;
            }, function () {
                console.log('Cannot get list position');
            });
        }

        function loadMedicine() {
            var config = {
                params: {
                    category: $scope.category
                }
            }
            apiService.get('/Medicine/GetAll', null, function (result) {
                $scope.listmedicine = result.data;
            }, function () {
                console.log('Cannot get list position');
            });
        }
        loadCountry();
        loadCategory();
        loadMedicine();
    }
})(angular.module('drugstore.medicine_batch'));