var kumori = {
    baseUrl: "http://kumori.astralis.fr/api/Notifications",
    
        getOpLink: function (operation, id) { return id == undefined ? `${kumori.baseUrl}/${operation}` : `${kumori.baseUrl}/${operation}/${id}`; },
        
            getNotifications: function (callback) {
                    // TODO: send a notification filter (filter by class, max rows, ..)
                            $.get(kumori.baseUrl, function (data) {
                                        callback(data);
                                                });
                                                    },
                                                    
                                                        clearNotifications: function (callback) {
                                                                // TODO
                                                                    },
                                                                    
                                                                        addNotification: function (content, callback) {
                                                                                $.ajax({
                                                                                            url: `${kumori.baseUrl}/create`,
                                                                                                        type: "POST",
                                                                                                                    contentType: "application/json",
                                                                                                                                data: JSON.stringify(content),
                                                                                                                                            success: function (data) {
                                                                                                                                                            callback(data);
                                                                                                                                                                        }
                                                                                                                                                                                });
                                                                                                                                                                                    },
                                                                                                                                                                                    
                                                                                                                                                                                        editNotification: function (content, callback) {
                                                                                                                                                                                                // TODO (fails if notification doesn't exist)
                                                                                                                                                                                                    },
                                                                                                                                                                                                    
                                                                                                                                                                                                        deleteNotification: function (notification, callback) {
                                                                                                                                                                                                                // TODO
                                                                                                                                                                                                                    },
                                                                                                                                                                                                                    
                                                                                                                                                                                                                        ackNotification: function (notification, callback) {
                                                                                                                                                                                                                                $.get(`${kumori.baseUrl}/ack/${notification.id}`, function (data) {
                                                                                                                                                                                                                                            callback(data);
                                                                                                                                                                                                                                                    });
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        }
