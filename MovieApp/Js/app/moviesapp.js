var movieApp = angular.module('MovieApp', []);

movieApp.controller('MovieListController', function($http) {
    var vm = this;
    var url = "api/movies";
    vm.movies = "";
    vm.movie = "";
    vm.sort = "Title";
    vm.filter = "";

    // fix to avoid error in console
    vm.movie.Picture = "/images/homealone.jpg";

    $http.get(url).then(function (response) {
        vm.movies = response.data;
    });

    vm.movieDetail = function (id) {
        $http.get(url+"/" + id).then(function (response) {
            vm.movie = response.data;
        });
    }

    vm.clear = function() {
        vm.movie = "";
        vm.filter = "";
    }
});