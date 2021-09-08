import {request} from '../utils/request.js'

export function getVertifyCode(parameter)
{
    return request(
        {
            url:'/VertifyCode',
            method:'get',
            data:parameter
        }
    )
}