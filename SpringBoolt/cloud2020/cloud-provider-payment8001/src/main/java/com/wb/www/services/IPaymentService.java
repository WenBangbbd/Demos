package com.wb.www.services;

import com.wb.www.entities.Payment;

public interface IPaymentService {

    int add(Payment payment);

    Payment find(int id);
}
