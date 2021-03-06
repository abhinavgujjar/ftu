﻿define(['plugins/router', 'durandal/app'], function (router, app) {
    return {
        router: router,
        search: function() {
            //It's really easy to show a message box.
            //You can add custom options too. Also, it returns a promise for the user's response.
            app.showMessage('Search not yet implemented...');
        },
        activate: function () {
            router.map([
                { route: '', title:'Welcome', moduleId: 'app/viewmodels/welcome', nav: true },
                { route: 'flickr', moduleId: 'app/viewmodels/flickr', nav: true },
                { route: 'Online Payment', moduleId: 'app/viewmodels/onlinepayment', nav: true }
            ]).buildNavigationModel();
            
            return router.activate();
        }
    };
});