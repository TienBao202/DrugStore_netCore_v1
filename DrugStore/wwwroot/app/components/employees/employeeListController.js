(function (app) {
    app.controller('employeeListController', employeeListController);

    employeeListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function employeeListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listemployees = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListEmployees = getListEmployees;

        $scope.search = search;

        $scope.deleteEmployee = deleteEmployee;

        function deleteEmployee(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Employee/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListEmployees();
        }
        function getListEmployees(page) {
            page = page || 0;
            var config = {
                params: {
                    status: $scope.status,
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Employee/GetAllPaging', config, function (result) {
                if (result.data.rowCount === 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listemployees = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load customer list failed.');
            });
        }

        $scope.getListEmployees();
    }
})(angular.module('drugstore.employees'));