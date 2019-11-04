﻿(function (app) {
    app.controller('customerListController', customerListController);

    customerListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function customerListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.listcustomers = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getListCustomers = getListCustomers;

        $scope.search = search;

        $scope.deleteCustomer = deleteCustomer;

        function deleteCustomer(id) {
            $ngBootbox.confirm('Bạn có muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/Customer/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công!');
                    search();
                }, function () {
                    notificationService.displayError('Đã xảy ra lỗi!');
                })
            });
        }

        function search() {
            getListCustomers();
        }
        function getListCustomers(page) {
            page = page || 0;
            var config = {
                params: {
                    type: $scope.type,
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/Customer/GetAllPaging', config, function (result) {
                if (result.data.rowCount == 0) {
                    notificationService.displayWarning('Không có bản ghi nào được tìm thấy!');
                }
                else {
                    notificationService.displaySuccess('Đã tìm thấy ' + result.data.rowCount + ' bản ghi!')
                }
                $scope.listcustomers = result.data.results;
                $scope.page = result.data.currentPage;
                $scope.pagesCount = result.data.pageCount;
                $scope.totalCount = result.data.rowCount;
                $scope.firstRowOnPage = result.data.firstRowOnPage;
                $scope.lastRowOnPage = result.data.lastRowOnPage;
            }, function () {
                console.log('Load customer list failed.');
            });
        }

        $scope.getListCustomers();
    }
})(angular.module('drugstore.customers'));