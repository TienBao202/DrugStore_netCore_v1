(function (app) {
    app.controller('medicine_categoryListController', medicine_categoryListController);

    medicine_categoryListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function medicine_categoryListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listmedicine_category = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListMedicine_category = getListMedicine_category;

        $scope.search = search;

        $scope.deleteMedicine_category = deleteMedicine_category;

        function deleteMedicine_category(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Medicine_Category/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListMedicine_category();
        }
        function getListMedicine_category(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Medicine_Category/GetAllPaging', config, function (result) {
                if (result.data.rowCount == 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listmedicine_category = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load customer list failed.');
            });
        }

        $scope.getListMedicine_category();
    }
})(angular.module('drugstore.medicine_category'));