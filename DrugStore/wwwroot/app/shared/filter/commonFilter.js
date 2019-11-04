(function (app) {
    app.filter('customerTypeFilter', function () {
        return function (input) {
            if (input === true)
                return 'Cá nhân';
            else
                return 'Công ty';
        }
    });
})(angular.module('drugstore.common'));