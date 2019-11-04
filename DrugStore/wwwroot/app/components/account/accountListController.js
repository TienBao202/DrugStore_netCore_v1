(function (app) {
    app.controller('accountListController', accountListController);

    accountListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function accountListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listaccount = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListAccount = getListAccount;

        $scope.search = search;

        $scope.deleteAccount = deleteAccount;

        function deleteAccount(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Account/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListAccount();
        }
        function getListAccount(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Account/GetAllPaging', config, function (result) {
                if (result.data.rowCount === 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listaccount = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load customer list failed.');
            });
        }

        $scope.getListAccount();
    }
})(angular.module('drugstore.account'));