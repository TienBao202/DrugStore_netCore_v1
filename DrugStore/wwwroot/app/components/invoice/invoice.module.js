/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.invoice', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('invoice', {
            url: "/invoice",
            templateUrl: "/app/components/invoice/invoiceListView.html",
            controller: "invoiceListController"
        }).state('invoice_add', {
                url: "/invoice_add",
                templateUrl: "/app/components/invoice/invoiceAddView.html",
                controller: "invoiceAddController"
            })
            .state('invoice_detail', {
                url: "/invoice_detail",
                templateUrl: "/app/components/invoice/invoice_detailView.html",
                controller: "invoice_detailController"
            });
    }
})();