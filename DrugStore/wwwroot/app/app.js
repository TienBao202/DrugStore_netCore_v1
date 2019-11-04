/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore',
        ['drugstore.customers',
            'drugstore.employees',
            'drugstore.medicine',
            'drugstore.medicine_batch',
            'drugstore.medicine_unit',
            'drugstore.medicine_category',
            'drugstore.supplier',
            'drugstore.account',
            'drugstore.invoice',
            'drugstore.supplier_group',
            'drugstore.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('dashboard', {
            url: "/Home",
            templateUrl: "/app/components/dashboard/dashboardView.html",
            controller: "dashboardController"
        });
        $urlRouterProvider.otherwise('/Home');
    }
})();