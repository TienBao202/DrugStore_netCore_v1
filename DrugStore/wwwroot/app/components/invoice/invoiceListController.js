(function (app) {
    app.controller('invoiceListController', invoiceListController);

    invoiceListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function invoiceListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listinvoice = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListInvoice = getListInvoice;

        $scope.search = search;

        $scope.deleteMedicine = deleteMedicine;

        function deleteMedicine(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Invoice/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListInvoice();
        }
        function getListInvoice(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Invoice/GetAllPaging', config, function (result) {
                if (result.data.rowCount === 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listinvoice = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load medicine list failed.');
            });
        }

        $scope.getListInvoice();
    }
})(angular.module('drugstore.medicine'));