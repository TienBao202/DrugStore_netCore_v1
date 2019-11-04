/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.supplier', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('supplier', {
            url: "/supplier",
            templateUrl: "/app/components/supplier/supplierListView.html",
            controller: "supplierListController"
        }).state('supplier_add', {
            url: "/supplier_add",
            templateUrl: "/app/components/supplier/supplierAddView.html",
            controller: "supplierAddController"
        }).state('supplier_edit', {
                url: "/supplier_edit/:id",
                templateUrl: "/app/components/supplier/supplierEditView.html",
                controller: "supplierEditController"
        });
    }
})();