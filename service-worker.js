self.addEventListener('install', event => {
    event.waitUntil(
        caches.open('repvault-cache').then(cache => {
            return cache.addAll([
                '/',
                '/css/site.css',
                '/js/site.js'
            ]);
        })
    );
});

self.addEventListener('fetch', event => {
    event.respondWith(
        caches.match(event.request).then(resp => {
            return resp || fetch(event.request);
        })
    );
});
