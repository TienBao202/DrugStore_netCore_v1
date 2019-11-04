/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.account', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('account', {
            url: "/account",
            templateUrl: "/app/components/account/accountListView.html",
            controller: "accountListController"
        }).state('account_add', {
            url: "/account_add",
            templateUrl: "/app/components/account/accountAddView.html",
            controller: "accountAddController"
            }).state('account_edit', {
                url: "/account_edit/:id",
                templateUrl: "/app/components/account/accountEditView.html",
                controller: "accountEditController"
        });
    }
})();