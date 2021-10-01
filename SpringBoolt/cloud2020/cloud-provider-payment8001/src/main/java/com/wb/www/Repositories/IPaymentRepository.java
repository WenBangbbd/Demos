package com.wb.www.Repositories;

import com.wb.www.entities.Payment;
import org.apache.ibatis.annotations.Mapper;

@Mapper
public interface IPaymentRepository {

    int add(Payment payment);
    Payment find(int id);
}
