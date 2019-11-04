(function (app) {
    app.controller('medicine_categoryEditController', medicine_categoryEditController);

    medicine_categoryEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', '$stateParams'];

    function medicine_categoryEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.medicine_category = {
            Date_Created: new Date(),
            Date_Modified: new Date(),

        };

        $scope.UpdateMedicine_category = UpdateMedicine_category;

        function loadMedicine_categoryDetail() {
            apiService.get('/Medicine_Category/GetById/' + $stateParams.id, null,
                function (result) {
                    $scope.medicine_category = result.data;
                 
                }, function (error) {
                    notificationService.displayError('Không tìm thấy thông tin!');
                });
        }

        function UpdateMedicine_category() {
            apiService.put('/Medicine_Category/Update', $scope.medicine_category,
                function (result) {
                    notificationService.displaySuccess(result.data.category_Name + ' đã cập nhật thành công.');
                    $state.go('medicine_category');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }

        function loadCategoryParent() {
            apiService.get('/Medicine_Category/GetAll', null, function (result) {
                $scope.listcategoryparent = result.data;
            }, function () {
                console.log('Cannot get list position');
            });
        }

        loadCategoryParent();

        loadMedicine_categoryDetail();
    }
})(angular.module('drugstore.medicine_category'));