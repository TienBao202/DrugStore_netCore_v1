(function (app) {
    app.controller('medicine_batchListController', medicine_batchListController);

    medicine_batchListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function medicine_batchListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listmedicine_batch = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListMedicine_batch = getListMedicine_batch;

        $scope.search = search;

        $scope.deleteMedicine_batch = deleteMedicine_batch;

        function deleteMedicine_batch(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Medicine_Batch/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListMedicine_batch();
        }
        function getListMedicine_batch(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Medicine_Batch/GetAllPaging', config, function (result) {
                if (result.data.rowCount === 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listmedicine_batch = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load customer list failed.');
            });
        }

        $scope.getListMedicine_batch();
    }
})(angular.module('drugstore.medicine_batch'));