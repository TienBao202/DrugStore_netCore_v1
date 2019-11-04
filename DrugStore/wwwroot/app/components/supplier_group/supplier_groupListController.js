(function (app) {
    app.controller('supplier_groupListController', supplier_groupListController);

    supplier_groupListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function supplier_groupListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listsupplier_group = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListSupplier_group = getListSupplier_group;

        $scope.search = search;

        $scope.deleteSupplier_group = deleteSupplier_group;

        function deleteSupplier_group(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Supplier_Group/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListSupplier_group();
        }
        function getListSupplier_group(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Supplier_Group/GetAllPaging', config, function (result) {
                if (result.data.rowCount === 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listsupplier_group = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load customer list failed.');
            });
        }

        $scope.getListSupplier_group();
    }
})(angular.module('drugstore.supplier_group'));