(function (app) {
    app.controller('medicineListController', medicineListController);

    medicineListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function medicineListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listmedicine = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListMedicine = getListMedicine;

        $scope.search = search;

        $scope.deleteMedicine = deleteMedicine;

        function deleteMedicine(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Medicine/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListMedicine();
        }
        function getListMedicine(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Medicine/GetAllPaging', config, function (result) {
                if (result.data.rowCount === 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listmedicine = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load medicine list failed.');
            });
        }

        $scope.getListMedicine();
    }
})(angular.module('drugstore.medicine'));