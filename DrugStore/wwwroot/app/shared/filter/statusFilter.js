(function (app) {
    app.filter('statusFilter', function () {
        return function (input) {
            if (input === 1)
                return 'Kích hoạt';
            else if (input === 0)
                return 'Khóa';
        }
    });
    app.filter('statusEmployeeFilter', function () {
        return function (input) {
            if (input === 1)
                return 'Đang làm việc';
            else if (input === 0)
                return 'Đã nghỉ';
        }
    });
    app.filter('statusCustomerFilter', function () {
        return function (input) {
            if (input === 1)
                return 'Hoạt động';
            else if (input === 0)
                return 'Ngừng hoạt động';
        }
    });
    app.filter('statusMedicineFilter', function () {
        return function (input) {
            if (input === 1)
                return 'Đang bán';
            else if (input === 0)
                return 'Ngừng bán';
        }
    });
    app.filter('statusMedicine_CategoryFilter', function () {
        return function (input) {
            if (input === 1)
                return 'Đang sử dụng';
            else if (input === 0)
                return 'Ngừng sủ dụng';
        }
    });
    app.filter('statusInvoiceFilter', function () {
        return function (input) {
            if (input === 1)
                return 'Đã hoàn thành';
            else if (input === 0)
                return 'Chưa hoàn thành';
        }
    });

})(angular.module('drugstore.common'));