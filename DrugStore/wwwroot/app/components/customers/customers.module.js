/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.customers', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('customers', {
            url: "/customers",
            templateUrl: "/app/components/customers/customerListView.html",
            controller: "customerListController"
        }).state('customer_add', {
            url: "/customer_add",
            templateUrl: "/app/components/customers/customerAddView.html",
            controller: "customerAddController"
        }).state('customer_edit', {
                url: "/customer_edit/:id",
                templateUrl: "/app/components/customers/customerEditView.html",
                controller: "customerEditController"
        });
    }
})();