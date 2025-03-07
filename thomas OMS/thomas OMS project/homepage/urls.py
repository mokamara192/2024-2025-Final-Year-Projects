# from django.urls import path
# from . import views
# from django.conf.urls import url, include

# urlpatterns = [
#     path('' , views.index , name='h_index'),
#     path('contact us',views.index1,name='contact_us'),
#     #path('api', views.followview.as_view(), name='api'),
#     #path('api11', views.followview1.as_view(), name='api11'),
#     url(r'api11/(?P<company_name>[A-Z a-z 0-9]+)$', views.followview1.as_view(), name='api11'),
#     url(r'api/(?P<company_name>[A-Z a-z 0-9]+)$', views.followview.as_view(), name='api'),
#    # url(r'token/(?P<company_name>[A-Z a-z]+)/(?P<password>[A-Z a-z 0-9]+)$',views.gettoken.as_view(),name='token'),
#    # url(r'api1/(?P<company_name>[A-Z a-z 0-9]+)$', views.transport.as_view(), name='api1'),
#    # url(r'api12/(?P<id>[0-9]+)/(?P<company_name>[A-Z a-z 0-9]+)$', views.transportid.as_view(), name='api12'),
#    # url(r'api123/(?P<company_name>[A-Z a-z 0-9]+)$', views.transport1.as_view(), name='api123'),
#    # url(r'api1234/(?P<company_name>[A-Z a-z 0-9]+)$', views.transport2.as_view(), name='api1234'),
#    # url(r'api12345/(?P<id>[0-9]+)/(?P<company_name>[A-Z a-z 0-9]+)$', views.transport3.as_view(), name='api12345'),
#     url(r'transportuser/(?P<company_name>[A-Z a-z 0-9]+)$', views.transportuser.as_view(), name='transportuser'),#1
#     url(r'transportuserid/(?P<id>[0-9]+)/(?P<company_name>[A-Z a-z 0-9]+)$', views.transportuserid.as_view(), name='transportuserid'),#12
#     url(r'useraccepted/(?P<company_name>[A-Z a-z 0-9]+)$', views.useraccepted.as_view(), name='useraccepted'),#1234
#     url(r'transporttoken/(?P<company_name>[A-Z a-z 0-9]+)$', views.transporttoken.as_view(), name='transporttoken'),#123
#     url(r'useracceptedid/(?P<id>[0-9]+)/(?P<company_name>[A-Z a-z 0-9]+)$', views.useracceptedid.as_view(), name='useracceptedid'),#12345
#     url(r'isaccepted/(?P<id>[0-9]+)/(?P<company_name>[A-Z a-z 0-9]+)$', views.transport4.as_view(), name='isaccepted'),

# ]

from django.urls import path, re_path, include  # Use re_path for regex-based patterns
from . import views

urlpatterns = [
    path('', views.index, name='h_index'),
    path('contact us', views.index1, name='contact_us'),
    # path('api', views.followview.as_view(), name='api'),
    # path('api11', views.followview1.as_view(), name='api11'),
    re_path(r'^api11/(?P<company_name>[A-Za-z0-9\s]+)$', views.followview1.as_view(), name='api11'),
    re_path(r'^api/(?P<company_name>[A-Za-z0-9\s]+)$', views.followview.as_view(), name='api'),
    # re_path(r'^token/(?P<company_name>[A-Za-z]+)/(?P<password>[A-Za-z0-9\s]+)$', views.gettoken.as_view(), name='token'),
    # re_path(r'^api1/(?P<company_name>[A-Za-z0-9\s]+)$', views.transport.as_view(), name='api1'),
    # re_path(r'^api12/(?P<id>[0-9]+)/(?P<company_name>[A-Za-z0-9\s]+)$', views.transportid.as_view(), name='api12'),
    # re_path(r'^api123/(?P<company_name>[A-Za-z0-9\s]+)$', views.transport1.as_view(), name='api123'),
    # re_path(r'^api1234/(?P<company_name>[A-Za-z0-9\s]+)$', views.transport2.as_view(), name='api1234'),
    # re_path(r'^api12345/(?P<id>[0-9]+)/(?P<company_name>[A-Za-z0-9\s]+)$', views.transport3.as_view(), name='api12345'),
    re_path(r'^transportuser/(?P<company_name>[A-Za-z0-9\s]+)$', views.transportuser.as_view(), name='transportuser'),  # 1
    re_path(r'^transportuserid/(?P<id>[0-9]+)/(?P<company_name>[A-Za-z0-9\s]+)$', views.transportuserid.as_view(), name='transportuserid'),  # 12
    re_path(r'^useraccepted/(?P<company_name>[A-Za-z0-9\s]+)$', views.useraccepted.as_view(), name='useraccepted'),  # 1234
    re_path(r'^transporttoken/(?P<company_name>[A-Za-z0-9\s]+)$', views.transporttoken.as_view(), name='transporttoken'),  # 123
    re_path(r'^useracceptedid/(?P<id>[0-9]+)/(?P<company_name>[A-Za-z0-9\s]+)$', views.useracceptedid.as_view(), name='useracceptedid'),  # 12345
    re_path(r'^isaccepted/(?P<id>[0-9]+)/(?P<company_name>[A-Za-z0-9\s]+)$', views.transport4.as_view(), name='isaccepted'),
]




