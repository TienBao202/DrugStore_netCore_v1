/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.supplier_group', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('supplier_group', {
            url: "/supplier_group",
            templateUrl: "/app/components/supplier_group/supplier_groupListView.html",
            controller: "supplier_groupListController"
        }).state('supplier_group_add', {
            url: "/supplier_group_add",
            templateUrl: "/app/components/supplier_group/supplier_groupAddView.html",
            controller: "supplier_groupAddController"
        }).state('supplier_group_edit', {
            url: "/supplier_group_edit/:id",
            templateUrl: "/app/components/supplier_group/supplier_groupEditView.html",
            controller: "supplier_groupEditController"
        });
    }
})();