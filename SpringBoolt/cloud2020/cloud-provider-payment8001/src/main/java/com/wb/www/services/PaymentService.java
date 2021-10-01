package com.wb.www.services;

import com.wb.www.Repositories.IPaymentRepository;
import com.wb.www.entities.Payment;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;

@Service
public class  PaymentService implements  IPaymentService{

    @Autowired
    private IPaymentRepository _rep;
    @Override
    public int add(Payment payment) {
      return  _rep.add(payment);
    }

    @Override
    public Payment find(int id) {
       return _rep.find(id);
    }
}