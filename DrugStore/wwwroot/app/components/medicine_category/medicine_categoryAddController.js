(function (app) {
    app.controller('medicine_categoryAddController', medicine_categoryAddController);

    medicine_categoryAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function medicine_categoryAddController(apiService, $scope, notificationService, $state) {
        $scope.medicine_category = {
            Date_Created: new Date(),
            Date_Modified: new Date(),
            Status: true

        };

        $scope.AddMedicine_category = AddMedicine_category;

        function AddMedicine_category() {
            apiService.post('/Medicine_Category/Create', $scope.medicine_category,
                function (result) {
                    notificationService.displaySuccess(result.data.category_Name + ' đã được thêm mới.');
                    $state.go('medicine_category');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
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
    }
})(angular.module('drugstore.medicine_category'));