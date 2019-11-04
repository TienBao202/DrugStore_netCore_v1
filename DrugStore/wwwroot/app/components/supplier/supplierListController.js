(function (app) {
    app.controller('supplierListController', supplierListController);

    supplierListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function supplierListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listsupplier = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListSupplier = getListSupplier;

        $scope.search = search;

        $scope.deleteSupplier = deleteSupplier;

        function deleteSupplier(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Supplier/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListSupplier();
        }
        function getListSupplier(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Supplier/GetAllPaging', config, function (result) {
                if (result.data.rowCount == 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listsupplier = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load supplier list failed.');
            });
        }

        $scope.getListSupplier();
    }
})(angular.module('drugstore.supplier'));