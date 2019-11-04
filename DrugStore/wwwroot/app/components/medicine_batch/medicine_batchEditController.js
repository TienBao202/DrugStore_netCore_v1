(function (app) {
    app.controller('medicine_batchEditController', medicine_batchEditController);

    medicine_batchEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function medicine_batchEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.medicine_batch = {
            Date_Created: new Date(),
            Date_Modified: new Date(),

        };

        $scope.UpdateMedicine_batch = UpdateMedicine_batch;

        function loadMedicine_batchDetail() {
            apiService.get('/Medicine_Batch/GetById/' + $stateParams.id, null,
                function (result) {
                    $scope.medicine_batch = result.data;
                   
                }, function (error) {
                    notificationService.displayError('Không tìm thấy thông tin!');
                });
        }

        function UpdateMedicine_batch() {
            apiService.put('/Medicine_Batch/Update', $scope.medicine_batch,
                function (result) {
                    notificationService.displaySuccess('Lô thuốc' + result.data.medicine_Batch_Code +  + ' đã cập nhật thành công.');
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

        loadMedicine_batchDetail();
    }
})(angular.module('drugstore.medicine_batch'));