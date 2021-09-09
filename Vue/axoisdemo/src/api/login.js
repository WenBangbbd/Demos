import {request} from '../utils/request.js'

export function getVertifyCode(parameter)
{
    return request(
        {
            url:`/api/Login/VertifyCode/${parameter}`,
            method:'get',
        }
    )
}